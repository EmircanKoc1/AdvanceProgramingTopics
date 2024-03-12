using System;
using System.Collections;
using System.Collections.Generic;

namespace AdvanceProgrammingTopics.Enumerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            IEnumerable en = stock;
            IEnumerable<string> en2 = stock;

            foreach (var item in Values())
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }




        }

        public static  IEnumerable<(string,string)> Values()
        {
            yield return ("emircan1", "koç");
            yield return ("emircan2", "koç");
            yield return ("emircan3", "koç");
            yield return ("emircan4", "koç");
        }


    }

    public class Stock : IEnumerable<string>
    {
        List<string> materials = new List<string>()
        {
            "kalem","matkap","defter","silgi"
        };

        public IEnumerator<string> GetEnumerator()
        {
            //return materials.GetEnumerator();
            return new StockEnumerator(materials);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StockEnumerator(materials);
            //return materials.GetEnumerator();
        }
    }

    public class StockEnumerator : IEnumerator<string>
    {
        List<string> _source;
        int _currentIndex = -1;
        public StockEnumerator(List<string> source) => _source = source;
        public string Current => _source[_currentIndex];
        object IEnumerator.Current => _source[_currentIndex];
        public void Dispose() => _source = null;
        public bool MoveNext() => ++_currentIndex < _source.Count;
        public void Reset() => _currentIndex = -1;


    }





}

