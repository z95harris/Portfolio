﻿using System;
using ZacharyHarris_PortfolioML.Model;

namespace MLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.SentimentText = "That is rude.";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
        }
    }
}
