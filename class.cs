using System;

namespace WompWomp
{
    public class Car
    {
        private string model;
        private int horsepower;
        public string model
        {
            get { return model; }
            set { model = value; }
        }
        public int horsepower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Toyota";
            myCar.horsepower = 150;
            Console.WriteLine("Model: " + myCar.model);
            Console.WriteLine("Horsepower: " + myCar.horsepower);
        }
    }
}
