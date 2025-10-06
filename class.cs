using System;

namespace WompWomp
{
    public class Car
    {
        private string model;
        private int horsepower;
        public void SetModel(string model, string horsepower)
        {
            this.model = model;
            this.horsepower = horsepower;

        }
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
        public static void Main()
        {

            Car car = new Car();
            car.SetModel("Toyota");
            car.SetHorsepower(150);
        }
    }
}
