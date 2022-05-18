
using StaticModifiers.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifiers
{

    public class Person 
    {
        public string fName;
        public string lName;

        public void Introduce() 
        { 
            fName = Console.ReadLine();
            lName = Console.ReadLine();
            Console.WriteLine("Welcome , " + fName +" " + lName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person shuvo = new Person();
            shuvo.Introduce();

            var result =  Calculator.Add(10,25);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
