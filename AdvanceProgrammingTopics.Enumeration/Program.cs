using System;
using System.ComponentModel;
using System.Reflection;

namespace AdvanceProgrammingTopics.Enumeration
{
    public class Program
    {

        static void Main(string[] args)
        {

            //string value = "Suspend";
            //OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), value);


            string database = "oracle";

            DatabaseType databaseType = (DatabaseType)Enum.Parse(typeof(DatabaseType), database, true);

            DatabaseType databaseType2 = Enum.Parse<DatabaseType>(database, true);

            DatabaseType databaseType3 = (DatabaseType)1;

            var enums = Enum.GetValues(typeof(DatabaseType));


            foreach (var item in enums)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();


            DatabaseType databaseType4 = DatabaseType.MySql;

            var desc = databaseType4.GetType()
                .GetField(databaseType4.ToString())
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;

            Console.WriteLine(desc);




            Console.WriteLine(Permissions.X | Permissions.Y | Permissions.Z);







        }

    }

    [Flags]
    public enum Permissions
    {
        X = 1,
        Y = 2,
        Z = 4,
        D = 8
    }

    public enum DatabaseType
    {
        [Description("1. mysql")]
        MySql,
        [Description("2. mssql")]
        MsSql,
        Oracle,
        PostgreSql,
        MongoDB
    }
}
