using System;

namespace AdvanceProgrammingTopics.Struct
{
    public class Program
    {
        static void Main(string[] args)
        {

            MyStruct m1 = new MyStruct()
            {
                X = 1,
                Y = 2
            };

            MyStruct m2 = new MyStruct()
            {
                X = 1,
                Y = 2
            };

            if (m1.Equals(m2))
                Console.WriteLine("eşit");





        }
    }


    struct MyStruct2
    {
        public int x;
        public int y;
        public bool z;

        public void NewStruct()
        {
            this = new MyStruct2();
        }


    }

    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
