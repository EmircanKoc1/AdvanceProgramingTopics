using System;

namespace AdvanceProgramminTopics.ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 1, b = 0;
                Console.WriteLine(a / 2);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }


    public class CustomException : Exception
    {

        public CustomException() : base("Custom Hata")
        {

        }

        public CustomException(string message) : base(message)
        {

        }


    }





}
