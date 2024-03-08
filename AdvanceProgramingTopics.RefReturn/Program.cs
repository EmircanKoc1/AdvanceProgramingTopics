

using System;
using System.Linq;

namespace AdvanceProgramingTopics.RefReturn
{
    public class Program
    {
        static void Main(string[] args)
        {

            //int _a = 5;
            //ref int __a = ref X(ref _a);

            //ref int X(ref int a) => ref a;

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int targetNumber = 4;

            ref int foundedNumber = ref FindNumber(array, ref targetNumber);

            Console.WriteLine("old array");
            array.ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });

            foundedNumber = 199999;

            Console.WriteLine("updated array ");
            array.ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });


            ref int FindNumber(int[] array, ref int targetNumber)
            {
                for (int i = 0; i < array.Length; i++)
                    if (targetNumber.Equals(array[i]))
                        return ref array[i];

                throw new Exception("Number not found");

            }


        }
    }
}
