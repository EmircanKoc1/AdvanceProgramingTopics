namespace AdvanceProgrammingTopics.ImplicitExplicitOperatorOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            A a = new B();

            B b = (B)new A();


        }
    }

    public class A
    {

        public static explicit operator B(A instance) => new B();
    }
    public class B
    {

        public static implicit operator A(B instance)
        {
            return new A();
        }

    }




}
