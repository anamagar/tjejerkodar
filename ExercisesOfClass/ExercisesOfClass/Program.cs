using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //default constructor
            Person p1 = new Person();
            Console.WriteLine("Name:" + p1.getName());
            p1.setName("Rafika");
            p1.setId("567");
            Console.WriteLine("Person p1 --> Name:" + p1.getName() + " id: "+p1.getId());
            //constructor with parameters
            Person p2 = new Person("Ana", "1234");
            Console.WriteLine("Person p2 --> Name:" + p2.getName() + " id: " + p2.getId());

            //Object not initiallize
            Person p3;
            p3 = p2;

            Console.WriteLine("Person p3 --> Name:" + p3.getName() + " id: " + p3.getId());

            p1 = p2;
            Console.WriteLine("Person p1 --> Name:" + p1.getName() + " id: " + p1.getId());

            p1 = null;
            p2 = null;
            p3 = null;
            //only remove 2 object because person3 was not created using new, and it point to the person2
            GC.Collect();

            //segmentation fault
            //Console.WriteLine("Person p1 --> Name:" + p1.getName() + " id: " + p1.getId());


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");

            //static method. Console is an example, static method can only be called from static method
            Console.ReadKey();
        }
    }
}
