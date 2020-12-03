using System;
using TestML.Model;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                // Add input data
                Console.WriteLine("----------------Ecrire votre phrase--------------------");
                //num2 = Convert.ToString(Console.ReadLine());

                var input = new ModelInput();
                input.SentimentText = Convert.ToString(Console.ReadLine()); ;

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                //Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
                if (result.Prediction == "1")
                {
                    Console.WriteLine($"****Is Toxic****");
                }
                else
                {
                    Console.WriteLine($"*****Is NOT Toxic*****");
                }
            }
        }
    }
}
