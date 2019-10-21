using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsius_fahren
{
    class Program
    {
        static void Main(string[] args)
        {

            Start:
            string answer;
            Console.WriteLine("Do you want to convert to celsius or fahrenheit (c, f): ");
            answer = Console.ReadLine();

            switch(answer)
            {
                case "c":
                    double fahrenheit;
                    double calcCelsius;
                    Console.WriteLine("Enter temperature in farenheit");
                    fahrenheit = int.Parse(Console.ReadLine());
                    calcCelsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit} fahrenheit equals to {Math.Round(calcCelsius,1)} in celsius \n");
                break;

                case "f":
                    double celsius;
                    double calcFahrenheit;
                    Console.WriteLine("Enter temperature in celsius");
                    celsius = int.Parse(Console.ReadLine());
                    calcFahrenheit = (celsius * 9) / 5 + 32;
                    Console.WriteLine($"{celsius} celsius equals to {Math.Round(calcFahrenheit, 1)} in fahrenheit \n");

                break;

            }

            goto Start;
            Console.ReadLine();
        }
    }
}
