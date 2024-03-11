using System;
using System.Dynamic;

namespace AdvanceProgramingTopics.Dynamic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            MyClass m = Activator.CreateInstance(type) as MyClass;

            dynamic x = new MyClass();

            dynamic obj = new ExpandoObject();
            obj.a = 22;


        }
    }
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("instance created");
        }
    }


}
