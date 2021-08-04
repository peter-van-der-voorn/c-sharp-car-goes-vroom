using System;

namespace car_goes_vroom
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Make:");
            string make = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Year:");
            string strYear = Console.ReadLine();

            if (Int32.TryParse(strYear, out int year))
            {
                Car myCar = new Car(make, model, year);
                Console.WriteLine(myCar.make);
                myCar.StartCar();
            }

        }

        public Car GetCarDetails()
        {
            Console.WriteLine("Make:");
            string make = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Year:");
            string strYear = Console.ReadLine();

            if(Int32.TryParse(strYear, out int year))
            {
                return new Car(make, model, year);
            }
            return null;

        }
    }

    class Car
    {
        public string make = "Honda";
        public string model;
        public int year;

        public Car(string carMake, string carModel, int carYear)
        {
            make = carMake;
            model = carModel;
            year = carYear;

        }

        public void StartCar()
        {
            Console.WriteLine("{0} goes vroom!", make);
        }
    }

    
}
