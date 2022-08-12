using System;

namespace Easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Average Calculator
            Console.WriteLine("::::::::: Average Calculator");
            var average = Average.Calculate(new float[] { 1, 2, 3, 4, 5, 2, 3 });
            Console.WriteLine("Average of 1, 2, 3, 4, 5, 2, 3 is {0}", average);

            // Triangel Drawer
            Console.WriteLine("::::::::: Triangel Drawer");
            Triangel.Draw();
            
            // Circle Drawer
            Console.WriteLine("::::::::: Circle Drawer");
            Circle.Draw();
            
        }
        
    }
}