using System;

namespace CSharpInterfacesTack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("*******Input*******");
            Console.Write("Enter the Fuel amount: ");
            int fuel = int.Parse(Console.ReadLine());
            Console.WriteLine("\n*******Output*******");
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
                Console.WriteLine("Car is Driving");
            else
                Console.WriteLine("Fuel is empty");
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}
