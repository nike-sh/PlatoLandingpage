using Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Press '1' for Bubble sort.");
            Console.WriteLine("Press '2' for Binary Search.");
            Console.WriteLine("Press '3' for Shuttle sort.");
            Console.WriteLine("Press '4' for Quick sort.");

            int keyPressed = int.Parse(Console.ReadLine());

            
            switch (keyPressed)
            {
                case 1 :
                    { new BubbleSort(); return; }
                case 2:
                    { new BinarySearch(); return; }
                case 3:
                    { new ShuttleSort(); return; }
                case 4:
                    { new QuickSort(); return; }
                default: break;
            }
          
        }

    }
}
