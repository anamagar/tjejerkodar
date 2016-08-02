using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    class Person
    {

        private
            //attribute 
            string name; 
            int    age;   
            string id; 

        struct gender
        {
            bool female;
            bool male;    
        };

        //Constructor
        public Person()
        {
            name = "none";
            age = 0;
            id = "";
        }
        //Constructor with arguments
        public Person(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        //Methods
        public void setName(string name) {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getId() 
        {
            return id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return age;
        }
    }
    /*class TestPerson {

        static void Main() {
            Person p1 = new Person(); //p1 is an object
            p1.setAge(10);
            p1.setName("Ana");
            p1.setId("1234567");

        }
    }*/
}
