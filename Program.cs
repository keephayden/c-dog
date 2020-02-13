using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c_dog
{
    public class dog
    {
        public String Name;
        public String Owner;
        public int Age;
        public enum Gender
        {
            Male,
            Female,
        }
        public dog(String name, String owner, int age, Enum Gender)
        {
            Name = name;
            Owner = owner;
            Age = age;
        }
        public string Bark(int i)
        {
            String woof = "Woof!";
            if (i == 1)
            {
                return woof;
            }
            else
            {
                int count = 2;
                while (count <= i)
                {
                    woof = woof + "Woof!";
                    count++;
                }
                return woof;
            }
        }

        public string getTag()
        {
            if (Age == 1)
            {
                string string1 = "If lost, call " + Owner + ". His name is " + Name + " and he is " + Age + " year old.";
                return string1;
            }
            else
            {
                string string1 = "If lost, call " + Owner + ". His name is " + Name + " and he is " + Age + " years old.";
                return string1;
            }
            
        }
    }
     class program
     {
        static void Main(string[] args)
        {
            dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            dog myDog = Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
    }
}
