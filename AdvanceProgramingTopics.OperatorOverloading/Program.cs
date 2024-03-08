using System.Collections.Generic;


namespace AdvanceProgramingTopics.OperatorOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "emir",
            };
            Book book = new Book
            {
                Name = "Asil kan",
                Author = "Kazım Yurdakul"
            };


            var result = student + book;


        }
    }


    public class Student
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new();
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public static Student operator +(Student student, Book book)
        {
            student.Books.Add(book);
            return student;
        }
        public static Student operator +(Book book, Student student)
        {
            student.Books.Add(book);
            return student;
        }


    }


}
