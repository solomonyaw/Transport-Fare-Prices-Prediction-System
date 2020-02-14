/**------------------------------------------------------------------------------------
 * This machine learning program was written by Solomon Yaw Adeklo,                   *
 * A final year computer science student of Valley View University,Ghana.             * 
 * This software is open sourced and anyone is free to use it for educational purpose * 
 *----------------------------------------------------------------------------------**/


using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.ML;


namespace TransportFarePrediction
{
    public partial class Transport : Form
    {
        static readonly string _trainDataPath = Path.Combine(Environment.CurrentDirectory, "Dataset", "taxi-fare-train.csv");
        static readonly string _TestDataPath = Path.Combine(Environment.CurrentDirectory, "Dataset", "taxi-fare-test.csv");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Dataset", "Model.zip");
        

        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Note: When you click on Predict Transport Fares it takes a few seconds for the system to provide outcome", "Message of Caution from Solomon Yaw Adeklo");
            MLContext mlContext = new MLContext(seed: 0);
            var model = Train(mlContext, _trainDataPath);
            Evaluate(mlContext, model);

            
            

            TestSinglePrediction(mlContext, model);
        }

        /** The Train() function is a function that build and trains the model by executing the following:
  1) load the data from disk into memory 
  2) extract the data and perform some transformation
  3) train the model 
  4) finally return the trained model
      The train function returns an model/ITransformer object. 
  This is an object used for data transformation,preprocessing and other tasks..**/

        public static ITransformer Train(MLContext mlContext, string datapath)
        {
            // IDataView object holds the training dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<TaxiTrip>(datapath, hasHeader: true, separatorChar: ',');

            var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "fare_amount")
            .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "VendorIdEncoded", inputColumnName: "vendor_id"))
            .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "RateCodeEncoded", inputColumnName: "rate_code"))
            .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "PaymentTypeEncoded", inputColumnName: "payment_type"))
            .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "VendorIdEncoded", inputColumnName: "vendor_id"))
            .Append(mlContext.Transforms.Concatenate("Features", "VendorIdEncoded", "RateCodeEncoded", "passenger_count", "trip_time", "trip_distance", "PaymentTypeEncoded"))
            .Append(mlContext.Regression.Trainers.FastTree());// Learning algorithm


            //create model
            var model = pipeline.Fit(dataView);

            //return the trained model
            return model;
        }

        // The evaluate function is used to access the model's performance. Accuracy for example

        public void  Evaluate(MLContext mLContext, ITransformer model)
        {

            IDataView dataView = mLContext.Data.LoadFromTextFile<TaxiTrip>(_TestDataPath, hasHeader: true, separatorChar: ',');
            var predictions = model.Transform(dataView);
            var metric = mLContext.Regression.Evaluate(predictions, "Label", "Score");

            lblOutcome.Text = "\n\nModel quality metrics output\n"  + "R - Squared Score is " + +metric.RSquared + "\n" + "  Root-Mean-Squared Error is: " + metric.RootMeanSquaredError;

        }

        //This method makes a prediction based on a single input method
        private void TestSinglePrediction(MLContext mlContext, ITransformer model)
        {

            try
            {
                var predictionFunction = mlContext.Model.CreatePredictionEngine<TaxiTrip, TaxiTripFarePrediction>(model);

                //Create a single TaxiTrip object to be used for prediction
                var taxiTripSample = new TaxiTrip()
                {
                    vendor_id = txtVendorID.Text,
                    rate_code = txtRateCode.Text,
                    passenger_count = float.Parse(txtPassengerCount.Text),
                    trip_time = float.Parse(txtTripTime.Text),
                    trip_distance = float.Parse(txtTripDistance.Text),
                    payment_type = txtPaymentType.Text,
                    fare_amount = float.Parse(txtFareAmount.Text)
                };

                if (txtPaymentType.Text != "CRD" && txtPaymentType.Text != "CSH")
                {
                    MessageBox.Show("Enter the the right payment type to get the right results");
                }

                if (txtVendorID.Text != "CMT" && txtVendorID.Text != "VTS")
                {
                    MessageBox.Show("Enter the the right vendor ID to get the right results");
                }



                //Make a prediction
                var prediction = predictionFunction.Predict(taxiTripSample);


                MessageBox.Show("Predicted fare is: " + prediction.fare_amount.ToString("c") + " while actual fare is: $15.5", "Prediction");
                lblOutcome.Text = "Predicted fare is: " + prediction.fare_amount.ToString("c") + " while actual fare is: $15.5";
            }
            catch(Exception)
            {
                MessageBox.Show("You are not allowed to enter ampty strings and characters in place of decimals");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVendorID.Text = "";
             txtRateCode.Text = "";
            txtPassengerCount.Text = "";
            txtTripTime.Text = "";
            txtTripDistance.Text = "";
            txtPaymentType.Text = "";
            txtFareAmount.Text = "";
        }
    }
}
