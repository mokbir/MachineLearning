using Microsoft.ML;
using System;
using System.IO;

namespace TaxiFarePrediction
{
    class Program
    {
        static readonly string _trainDataPath = Path.Combine(Environment.CurrentDirectory,"Data","taxi-fare-train.csv" );
        static readonly string _testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "taxi-fare-train.csv");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Model.zip");  
        
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            
            MLContext mlContext = new MLContext(seed: 0);

            var model = Train(mlContext, _trainDataPath);

            Evaluate(mlContext, model);
        }

        private static void Evaluate(MLContext mlContext, ITransformer model)
        {
            throw new NotImplementedException();
        }

        public static ITransformer Train(MLContext mlContext, string dataPath)
        {
            return null;
        }
    }


  
}
