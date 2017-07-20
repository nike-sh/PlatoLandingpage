using Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinarySearch : DataInput
    {
        public BinarySearch()
        {
            int[] unsortedNumbers = GetNumbers();

            SortedNumberList(unsortedNumbers);

        }

        public override int[] SortedNumberList(int[] unsortedList)
        {

            for (int i = 0; i < unsortedList.Length; i++)
            {
                int min = 0;
                int max = 0;
                int middle = 0;


                if (unsortedList[i] > unsortedList[i + 1])
                {
                    unsortedList[i] = max;
                }
                else if (unsortedList[i] < unsortedList[i + 1])
                {
                    unsortedList[i] = min;
                }
                else if (unsortedList[i] == unsortedList.Length/2 )
                {
                    unsortedList[i] = middle;
                }

            }
            return unsortedList;

        }
    }
}
