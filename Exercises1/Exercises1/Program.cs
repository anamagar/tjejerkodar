using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World \n");
            MyClass c = new MyClass();
            c.printHello("Ana \n");
            
            //Differents type of data
            // Always is the <type of data> <name>  <=> <value> <;>  
            int value = 5;

            Console.Write("value = "+ value);
            //Error the compilator int can only be integer
            //value = 5.5;
            double variable = 5.5; // is never used.

            Console.Write("value = " + value + "\n");

            //String 
            string name = "Ana";
            Console.Write("name = " + name + "\n");

            //how to write variables
            //CamelCasse

            //variables cannot be repeat the same name of variable
            //int value;

            //Array 
            string[] teachersName = { "Rafika", " Ana" };
            Console.Write("element = " + teachersName[0] + "\n");
            Console.Write("element = " + teachersName[1] + "\n");

            //Array 
            //how to declare array, differents types of array
            int[] elemets = {5,6};
            
            //how to access an array
            Console.Write("element = " + elemets[0] + "\n");
            Console.Write("element = " + elemets[1] + "\n");
            //but happens when you try to access to elemets[2]

            Console.Write("element length = " + elemets.Length + "\n");
            Console.Write("element is fixed size = " + elemets.IsFixedSize + "\n");

            int[] arrayOf10Elements = new int[10];
            Console.Write("element zero of the array = " + arrayOf10Elements[0] + "\n");

            //Multidimensional Array
            int[,] matrix = { { 0, 1 }, { 2, 3 } };


            //Console.Write("element = " + elemets[2] + "\n");
            //GIT 
            //if
            int value_of_x = 10;

            if (value_of_x < 200)
            {
                Console.Write("x is bigger than 200 " + value_of_x + "\n");
            } else {
                Console.Write("x is smaller than 200 " + value_of_x + "\n");
            }

            //for
            int[] arrayOfElements = { 200, 201, 500 };
            for (int i = 0; i < arrayOfElements.Length; i++) {

            }



            //while, do while
            int index = 0;
            while (index < 10) {
                Console.Write("index " + index + "\n");
                index++;
            }
            index = 0;
            do {
                Console.Write("index " + index + "\n");
                index++;
            } while (index < 10);

            //, function, for 


            Console.ReadKey();

        }

        public int getValue() {
            int value = 0;
            return value;
        }

    }

   
}
