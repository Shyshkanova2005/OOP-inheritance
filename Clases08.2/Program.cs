using System;

namespace Clases08._2
{
    class Vechicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        protected int Year { get; set; }

        public Vechicle (string make, string model, int year )
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void StartEngine()
        {
            Console.WriteLine($"Марка: {Make}, модель : {Model}, рік {Year} завелась");
        }

    }

    class Car : Vechicle
    {
        public int TrunkSize { get; set; }

        public Car (string make, string model, int year, int trunksize )
            :base(make, model, year)
        {
            TrunkSize = trunksize;
        }
        public new void StartEngine()
        {
            base.StartEngine();
            Console.WriteLine($"Розмір багажника: {TrunkSize}");
        }
    }

   class Motorcycle : Vechicle
    {
        public string HasSidecar { get; set; }
        public Motorcycle(string make, string model, int year, string hassidecar)
           : base(make, model, year)
        {
            HasSidecar = hassidecar;
        }
        public new void StartEngine()
        {
            base.StartEngine();
            Console.WriteLine($"Наявність коляски : {HasSidecar}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Форд", "Фокус", 2012, 12);
            car.StartEngine();

            Motorcycle motorcycle = new Motorcycle("Ямаха", "ххх", 2001, "yes");
            motorcycle.StartEngine();
        }
    }
}
