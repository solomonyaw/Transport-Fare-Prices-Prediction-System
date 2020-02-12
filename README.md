# Transport Fare Prices Prediction System
 A machine learning model using regression analysis - Built with ML.NET Framework
 
 This is a machine learning model for predicting the price of transport fair using regression analysis.The system was trained with some dataset which have been labeled for supervised learning.  
# Dataset
The data contains in the data fields contain the following fields:

  vendor_id: Unique ID of the taxi vendor.</br>
rate_code: rate type of the taxi trip.
passenger_count: number of passengers for the trip.
trip_time_in_secs: The amount of time the trip took. You need to predict the fare before the trip is completed. So at that moment you don’t know how long the trip would take. Therefore, the trip time is not a feature and you’ll exclude this column from the model.
trip_distance: The distance of the trip.
payment_type: The payment method  – either credit card or cash
fare_amount: The total taxi fare paid is the label to be predicted
