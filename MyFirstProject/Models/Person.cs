using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
   
    public class Person{
        public string Name { get; set; }
        public Person(string n)
        {
            Name = n;
        }
        public static List<Person> GetName()
        {
            return new List<Person>
            {
                new Person("person 1"),
                new Person("person 2"),
                new Person("person 3")
            };
        }  
    }
}
