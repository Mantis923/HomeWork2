/// Part 2		
/// File Name: HomeWork2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
///
///This is a program that prompts the user to enter a temperature in degrees Farenheit in non fractional form
/// The program then prints out the equivalent celsius temperature,up to one decimal point.

using System;

namespace HomeWork2_Graded_Assignment_
{
    class Program2
    {
        static void Main(string[] args)
        {
            double degreesC;

            Console.Write("Enter a temperature in degrees Frarenheit (whole numbers): ");
            double degreesF = Convert.ToInt32(Console.ReadLine());

            degreesC = (5 * (degreesF - 32.0) / 9);


            Console.WriteLine(degreesF + " degrees Fahrenheit = " + degreesC.ToString("0.0") + " " + "Celsius");
            Console.ReadKey();


        }
    }
}