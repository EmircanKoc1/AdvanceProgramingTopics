namespace AdvanceProgrammingTopics.Generic
{
    public class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class MyClass<T, T2, T3, T4>
        where T : class
        where T2 : class
        where T3 : class
    {
        T field;
        public T2 Property { get; set; }
        public T3 Method2(T3 param)
        {
            return param;
        }

        public T6 Method3<T5, T6>(T6 param, T5 param2)
        where T6 : class
        where T5 : struct
        {
            return param;

        }


    }




}
