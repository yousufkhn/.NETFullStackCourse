using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupplesDemo
{
    internal class TuppleCRUD
    {
       
        public static void TuppleCRUDMain()
        {
            // Create a tuple
            var person = (Id: 1, Name: "John", Age: 30);
            Console.WriteLine($"Created: Id={person.Id}, Name={person.Name}, Age={person.Age}");

            // Read values from the tuple
            Console.WriteLine($"Read: Id={person.Id}, Name={person.Name}, Age={person.Age}");

            // Update tuple (creating a new tuple with updated values)
            var updatedPerson = (person.Id, person.Name, Age: 31);
            Console.WriteLine($"Updated: Id={updatedPerson.Id}, Name={updatedPerson.Name}, Age={updatedPerson.Age}");

            // Delete (or effectively discard) the tuple
            person = (0, "", 0); // Reset with default values
            Console.WriteLine($"Deleted (Reset): Id={person.Id}, Name={person.Name}, Age={person.Age}");

            // Setting to null (if tuple is declared as nullable)
            // person = null; // Uncomment if person is a nullable tuple type
        }
    }

}
