using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AdvanceProgrammingTopics.Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region IComparer
            List<Person> persons = new List<Person>();

            persons.Sort(new PersonComparer());


            #endregion

            #region IComparable
            var person1 = new Person();
            var person2 = new Person();

            var compareResult = person1.CompareTo(person2);
            #endregion

            #region IClonable

            Person person3 = new Person();
            Person personClone = person3.Clone() as Person;


            #endregion

            #region INotifyPropertyChanged
            Person person5 = new Person();
            person5.PropertyChanged += (sender, e) =>
            {
                Console.WriteLine(e.PropertyName);
            };

            person5.Age = 22;
            #endregion

            #region IEquatable 
            var personE1 = new Person();
            var personE2 = new Person();

            person1.Equals(personE2);


            #endregion

            #region IEnumerable
            Depo depo = new();

            foreach (var item in depo)
            {

            }




            #endregion


        }

    }

    public class Depo : IEnumerable
    {
        List<string> list = new List<string>() { "kalem", "silgi", "defter", "traş bıçağı" };
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }


    public class Person : IComparable<Person>, ICloneable, INotifyPropertyChanged, IEquatable<Person>
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get => age;
            set
            {
                age = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Age)));
            }
        }


        public object Clone()
        {
            return this.MemberwiseClone();

            //return new Person()
            //{
            //    Name = Name,
            //    Age = Age,
            //};
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public bool Equals(Person other)
        {
            return Age == other.Age && Name == other.Name;
        }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }


}
