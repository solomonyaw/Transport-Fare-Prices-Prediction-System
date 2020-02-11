using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace TransportFarePrediction
{
    class TaxiTrip
    {
        [LoadColumn(0)]
        public string vendor_id;

        [LoadColumn(1)]
        public string rate_code;

        [LoadColumn(2)]
        public float passenger_count;

        [LoadColumn(3)]
        public float trip_time;

        [LoadColumn(4)]
        public float trip_distance;

        [LoadColumn(5)]
        public string payment_type;

        [LoadColumn(6)]
        public float fare_amount;
    }
}
