using System;


namespace ObjectOnCar
{
    
    internal class Program

    {
       String CarColor = "blue";
        String CarSpeed = "120KMPH";
        String Model = "hyundai";
        String CarType = "Automatic";
     static void myFavouriteCar()
        {
            Console.WriteLine("my favourite car should have all this charaters/facilities");
        }
        static void Main(string[] args)
        {
            Program c1 = new Program();
            Console.WriteLine(c1.CarSpeed);
            Console.WriteLine(c1.Model);
            Console.WriteLine(c1.CarType);
            Console.WriteLine(c1.CarColor);
            myFavouriteCar();
            Console.ReadLine();

        }
    }
}
