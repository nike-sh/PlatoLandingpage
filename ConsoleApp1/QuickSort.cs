using Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuickSort
    {
        public int[] orderedList { get; set; }

        public QuickSort()
        {
            int[] unorderedList = new int[] { 4, 6, 2, 7, 3, 9, 12, 8 };
            int lengthOfUnorderedArray = unorderedList.Length;
            orderedList = new int[lengthOfUnorderedArray];


            for (int i = 0; i < lengthOfUnorderedArray - 1; i++)
            {
                int highestNumber = getHighestNumber(unorderedList[i], unorderedList[i + 1]);

               orderedList[lengthOfUnorderedArray-1] = highestNumber;

            }
            Console.WriteLine(orderedList);
        }

        public int getHighestNumber(int x, int y)
        {
            int firstVal = x;
            int seccondVal = y;

            if (firstVal > seccondVal)
            {
                return firstVal;
            }
            else
            {
                return seccondVal;
            }
        }
    }
}

