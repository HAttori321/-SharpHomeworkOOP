using System;

namespace OOP
{
    public class Freezer
    {
        private string model;
        private int year;
        private double maxTemp;
        private double minTemp;
        private string color;

        private static string production;
        private static int count;

        public Freezer(string model, int year)
        {
            this.model = model;
            this.year = year;
        }

        public Freezer(string model, int year, double maxTemp, double minTemp, string color) : this(model, year)
        {
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;
            this.color = color;
        }

        static Freezer()
        {
            production = "Samsung";
            count = 70;
        }

        public Freezer()
        {
            this.model = "Standard";
            this.maxTemp = 0;
            this.minTemp = 0;
            this.color = "none";
        }

        public override string ToString()
        {
            return $"Model: {model}, Year: {year}, Max Temperature: {maxTemp}, Min Temperature: {minTemp}, Color: {color}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer1 = new Freezer("Model AWfdfdsS1312", 2022);
            Freezer freezer2 = new Freezer("Model BEQWRE1242", 2021, -18.5, -24.0, "White");
            Freezer freezer3 = new Freezer();

            Console.WriteLine(freezer1.ToString());
            Console.WriteLine(freezer2.ToString());
            Console.WriteLine(freezer3.ToString());

            Console.ReadLine();
        }
    }
}