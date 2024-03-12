using System;

namespace AdvanceProgrammingTopics.Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyEventPublisher m = new MyEventPublisher();
            m.MyEvent += () =>
            {

            };

            m.MyEvent += X;

            m.RaiseEvent();

            void X()
            {
            };


        }
    }

    public class MyEventPublisher
    {
        public delegate void XHandler();

        XHandler xdelegate;

        public event XHandler MyEvent
        {
            add
            {
                xdelegate += value;
                Console.WriteLine("Evente metot bağlandı");
            }
            remove
            {
                xdelegate -= value;
                Console.WriteLine("eventten metot çıkarıldı");

            }
        }

        public void RaiseEvent()
        {
            //MyEvent();
            xdelegate();

        }

    }

}
