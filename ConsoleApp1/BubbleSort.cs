using Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BubbleSort : DataInput
    {
        public BubbleSort()
        {
            int[] unsortedNumbers = GetNumbers();

            var sortedList = SortedNumberList(unsortedNumbers);

            for (int i = 0; i < sortedList.Length; i++)
            {
                Console.WriteLine(sortedList[i]);
            }
            Console.ReadLine();

        }

        public override int[] SortedNumberList(int[] unsortedList)
        {
            int noMoreSwaps = 0;

            while (noMoreSwaps == 0 )
            {
                for (int x = 0; x < unsortedList.Length-1; x++)
                {
                    if (unsortedList[x] > unsortedList[x + 1])
                    {
                        int firstNumber = unsortedList[x];

                        unsortedList[x] = unsortedList[x + 1];

                        unsortedList[x + 1] = firstNumber;
                    }
                }
                noMoreSwaps += 1;
            }
            return unsortedList;
        }
    }
}
