﻿using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFarePrediction
{
    class TaxiTripFairPrediction
    {
        [ColumnName("Score")]
        public float fare_amount;
    }
}
