using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_Csharp
{
    internal class TupleDataType
    {
        public void Sample()
        {
            // Creating a tuple using ValueTuple
            (int, string, bool) person = (1, "John Doe", true);

            // Accessing tuple elements
            Console.WriteLine($"ID: {person.Item1}");
            Console.WriteLine($"Name: {person.Item2}");
            Console.WriteLine($"Is Active: {person.Item3}");

            // Creating a tuple with named elements
            (int Id, string Name, bool IsActive) namedPerson = (2, "Jane Doe", false);

            // Accessing named tuple elements
            Console.WriteLine($"ID: {namedPerson.Id}");
            Console.WriteLine($"Name: {namedPerson.Name}");
            Console.WriteLine($"Is Active: {namedPerson.IsActive}");

            // Using tuples as return types
            var result = GetPerson();
            Console.WriteLine($"ID: {result.Id}, Name: {result.Name}, Is Active: {result.IsActive}");
        }

        public (int Id, string Name, bool IsActive) GetPerson()
        {
            return (3, "Alice Smith", true);
        }
    }
}
