using System;
using System.Diagnostics;

namespace classTesk_lssn_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //q1
               Cookie co1 = new Cookie();
               co1.Gluten = true;
               co1.Suger = 4;
               co1.Flour = 0.400d;
               co1.NumOfEggs = 3;

               Cookie co2 = new Cookie();
               co2.Gluten = false;
               co2.Suger = 5;
               co2.Flour = 0.400d;
               co2.NumOfEggs = 4;

               Cookie co3 = new Cookie();


               Console.WriteLine(printDetails(co1));
               Console.WriteLine(printDetails(co2));
               co1.Suger = 6;

               Console.WriteLine(printDetails(co1));
               Console.WriteLine(printDetails(co2));
               co1 = co2;
               co2.NumOfEggs = 5;

               Console.WriteLine(printDetails(co1));
               Console.WriteLine(printDetails(co2));
               
            //q2
            Car car1 = new Car();
            car1.Speed = 55;
            Console.WriteLine($"{car1.Print()}");

            Console.WriteLine("Enter How fester do you like to drive?");
            int newSpeed = Convert.ToInt32(Console.ReadLine());
            car1.GetFester(newSpeed);
            Console.WriteLine($"{car1.Print()}");
            car1.GetSlower(2);
            Console.WriteLine($"{car1.Print()}");
            Console.WriteLine($"{car1.Stop()}");


        }

        public static string printDetails(Cookie c)
        {
            string res = "Details of cookie:\n";
            res += $"Gluten: {c.Gluten}\n";
            res += $"number of eggs: {c.NumOfEggs}\n";
            res += $"Suger: {c.Suger}\n";
            res += $"Flour: {c.Flour}\n";

            return res;

        }
    }
}
