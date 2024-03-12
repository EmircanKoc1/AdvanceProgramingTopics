using System.Collections.Generic;
using System.Text.Json;
using sd = System.Dynamic;
namespace AdvanceProgrammingTopics.ExpandoObject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dynamic expandoObject = new sd.ExpandoObject();

            expandoObject.Name = "Emir";
            expandoObject.Surname = "Koç";
            expandoObject.Age = 31;


            dynamic person1 = new sd.ExpandoObject();
            person1.Name = "emir";
            person1.Surname = "koç";
            person1.Year = 22;

            List<sd.ExpandoObject> list = new List<sd.ExpandoObject>
            {
                person1,
                person1,
                person1
            };
            var jsonData = JsonSerializer.Serialize(list);
            dynamic data = JsonSerializer.Deserialize<List<sd.ExpandoObject>>(jsonData);




        }
    }
}
