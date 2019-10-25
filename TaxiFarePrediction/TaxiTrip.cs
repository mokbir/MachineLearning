using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;

namespace TaxiFarePrediction
{
    public class TaxiTrip
    {
        [LoadColumn(0)]
        public string VendorId;
        [LoadColumn(1)]
        public string Ratecode;
        [LoadColumn(2)]
        public float Passengercount;
        [LoadColumn(3)]
        public float Triptime;
        [LoadColumn(4)]
        public float TripDistance;
        [LoadColumn(5)]
        public string PaymentType;
        [LoadColumn(6)]
        public float FareAmount;

    }

    
    public class TaxiTripFarePrediction
    {
        [ColumnName("Score")]
        public float Score;
    }
}
