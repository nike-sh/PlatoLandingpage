using Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ShuttleSort : DataInput
    {
        public ShuttleSort()
        {
            int[] unsortedNumbersList = GetNumbers();

            int[] sortedList = SortedNumberList(unsortedNumbersList);

            for (int i = 0; i < sortedList.Length; i++)
            {
                Console.WriteLine(sortedList[i]);
            }
            Console.ReadLine();

        }
        public override int[] SortedNumberList(int[] unsortedList)
        {
            int[] sortedList = new int[unsortedList.Length];

            int firstVal = unsortedList[0];
            int seccondVal = unsortedList[1];
            int carryingVal = 0;

            for (int i = carryingVal ; i < unsortedList.Length - 1; i++)
            {
                if (unsortedList[i] > unsortedList[++i])
                {
                    carryingVal = unsortedList[i];
                }
                else
                {
                    carryingVal = unsortedList[++i];
                }



            }




            // int comparisonOne = unsortedList[0];
            // int comparisonTwo = unsortedList[1];

            // if (comparisonOne > comparisonTwo)
            // {
            //     sortedList[0] = comparisonOne;
            // }
            //if (unsortedList[i] > unsortedList[i + 1])
            // {
            //     unsortedList[i + 1] = sortedList[i];
            //     unsortedList[i] = sortedList[i + 1];
            // }
            //}

            return sortedList;
        }
    }
}
