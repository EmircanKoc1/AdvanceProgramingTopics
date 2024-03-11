using System;

namespace AdvanceProgrammingTopics.Delegates
{
    public class Program
    {
        public delegate void Xhandler();

        public delegate (int, char) YHandler(A a, (string, int) p);

        public delegate T3 GHandler<T1, T2, T3>(T1 param, T2 param2);

        static void Main(string[] args)
        {
            Xhandler xdelegate = new Xhandler(X);
            Xhandler xdelegate2 = X;
            Xhandler xdelegate3 = () => { };
            Xhandler xdelegate4 = delegate () { };

            xdelegate();
            xdelegate.Invoke();



            YHandler ydelegate = (a, t) => (1, 'a');

            (int, char) r = ydelegate(new A(), ("miav", 22));
            var r2 = ydelegate.Invoke(new A(), ("miav", 22));

            Xhandler xMulticastDelegate = () => Console.WriteLine("x1");

            xMulticastDelegate += () => Console.WriteLine("x2");
            xMulticastDelegate += () => Console.WriteLine("x3");
            xMulticastDelegate += Method3;
            xMulticastDelegate += () => Console.WriteLine("x4");
            xMulticastDelegate += () => Console.WriteLine("x5");
            xMulticastDelegate += () => Console.WriteLine("x6");

            xMulticastDelegate.Invoke();

            xMulticastDelegate -= Method3;
            Console.WriteLine("**************");
            xMulticastDelegate.Invoke();

            var methods = xMulticastDelegate.GetInvocationList();

            foreach (var method in methods)
                Console.WriteLine(method.Method.Name);

            Xhandler x1Delegate = Method3;
            Xhandler x2Delegate = Method3;
            Xhandler x3Delegate = Method3;
            Xhandler x4Delegate = Method3;
            Xhandler x5Delegate = Method3;

            x1Delegate = x1Delegate + x2Delegate + x3Delegate + x4Delegate + x5Delegate;

            GHandler<string, int, bool> gDelegate = (text, number) =>
            {
                return true;
            };



            void Method3()
            {
                Console.WriteLine("Metot3");
            }


            void X()
            {
                Console.WriteLine("X metotu");
            }



        }




    }

    public class A
    {

    }


}
