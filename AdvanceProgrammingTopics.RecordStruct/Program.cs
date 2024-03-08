using System;

namespace AdvanceProgrammingTopics.RecordStruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyRecordStruct m = new MyRecordStruct(1, 2);

            var m2 = m with { a = 321, b = 123 };


            int date1 = 0005;
            int date2 = 0022;
            int date3 = 0123;
            int date4 = 1453;


            Console.WriteLine(date1.ConvertIntToDate() + " 00:05");
            Console.WriteLine(date2.ConvertIntToDate() + " 00:22");
            Console.WriteLine(date3.ConvertIntToDate() + " 01:23");
            Console.WriteLine(date4.ConvertIntToDate() + " 14:53");


        }

    }

    public readonly record struct MyRecordStruct(int a, int b)
    {

    }


    public static class Extensions
    {

        public static string getOCLGActionName(this string _action)
        {
            var returnValue = _action switch
            {
                "C" => "Telefon Çağrısı",
                "M" => "Toplantı",
                "T" => "Görev",
                "E" => "Not",
                "P" => "Kampanya",
                "N" => "Diğer",
                _ => "Belirtilmemiş",
            };
            return returnValue;
        }



        public static string IsNullOrEmpty(this string variable, string returnValue)
        => !string.IsNullOrEmpty(variable) ? variable : returnValue;

        //static void x()
        //{
        //    var StartTime = DateTime.Now;
        //    string val = string.Empty;

        //    val = StartTime.ToString().Length == 3 ?
        //        DateTime.ParseExact($@"0{o.BeginTime}", "HHmm", CultureInfo.InvariantCulture, DateTimeStyles.None).ToString("HH:mm")
        //        :
        //        DateTime.ParseExact(o.BeginTime.ToString(), "HHmm", CultureInfo.InvariantCulture, DateTimeStyles.None).ToString("HH:mm");


        //}

        //public static string ConvertDateToString(
        //    this DateTime date,
        //    string dateFormat,
        //    CultureInfo culture,
        //    DateTimeStyles dateStyle,
        //    Func<string, bool> predicate)
        //{

        //    var stringDate = date.ToString();
        //    var state = predicate(stringDate);



        //    return state ? 
        //        DateTime.ParseExact(stringDate,culture,)



        //}

        public static string ConvertDateToFlatString(this DateTime date)
        {
            var arr = date.ToString("HH:mm").Split(":");
            arr[0] = int.Parse(arr[0]).ToString();

            return string.Concat(arr);

        }

        public static string ConvertIntToDate(this int time)
        {
            var stringDate = time.ToString();
            var arr = stringDate.ToCharArray();
            var length = stringDate.Length;


            return length switch
            {
                1 => $"00:0{arr[0]}",
                2 => $"00:{arr[0]}{arr[1]}",
                3 => $"0{arr[0]}:{arr[1]}{arr[2]}",
                4 => $"{arr[0]}{arr[1]}:{arr[2]}{arr[3]}",
                _ => throw new Exception("Date is bad ")
            };

        }



    }





}
