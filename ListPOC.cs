using System;
using System.Collections.Generic;

namespace DotNetDemo
{
    class ListPOC
    {
        // Show method to display the list of subject and students name
        static void Show(IList<string> list)
        {

            // Iterating through the list
            foreach (string str in list)
            {
                Console.WriteLine("\t" + str);
            }
        }

        // Driver code from here
        private static void Main()
        {

            // Declaring a list of subjects
            string[] subjects = { "C", "JAVA", "HTML", "CSS",
                          "Data Structures", "JavaScript" };

            // Defining  a list
            List<string> data = new List<string>(); //Object is created here 

            // Adding students to the list
            data.Add("Ragini");
            data.Add("R Singh");
            data.Add("Ragini Singh");

            // Displaying subjects
            Console.WriteLine("Subjects Name: ");
            Show(subjects);

            // Displaying students
            Console.WriteLine("Students Name: ");
            Show(data);
        }
    }
}

