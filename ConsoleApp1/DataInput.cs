using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    abstract class DataInput
    {

        public int[] GetNumbers()
        {
            int[] listOfNumbers = { 12, 6, 43, 23, 62, 91, 15, 77 };

            return listOfNumbers;



            //    var randomNumberList = new List<int>();

            //    Console.WriteLine("How many numbers would you like to sort");
            //    int length = int.Parse(Console.ReadLine());

            //    for (int i = 0; i <= length; i++)
            //    {
            //        int randomNumber = RandomNumberGenerator();
            //        Console.Write(randomNumber + ",");
            //        randomNumberList.Add(randomNumber);

            //    }
            //    Console.ReadLine();
            //    return randomNumberList;
            //
        }

        //int RandomNumberGenerator()
        //{
        //    Random rnd = new Random();
        //    int randomNumber = rnd.Next(1, 100);

        //    return randomNumber;
        //}

        public abstract int[] SortedNumberList(int[] unsortedList);
    }
}

