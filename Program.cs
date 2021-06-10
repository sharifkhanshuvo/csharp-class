using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Csharp2
{
    class Animal
    {
        string name = "Audi";
        int Age = 6;
      public  void Details()
            
        {
            Console.WriteLine("Name" +" "+ name + " " + "Age" +" " +Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Details();
          
            //** array**//
          //  int[] numbers = new int[] { 20, 23, 56, 75 };
            //int myAge = age(2021,1995);
            //if(myAge>18)
            // Console.WriteLine("Adult");
           // Console.WriteLine(numbers[3]);
            //list
           // List<string> names = new List<string>();
           // names.Add("Mr");
           // names.Add("Sharif");
           // names.Add("khan");
           // for(int i=0; i<names.Count; i++)
            //{
              //  Console.WriteLine(names[i]);
            //}
           // else
              //  Console.WriteLine("NOt Adult");
        }
        /*public static int age (int Currentyear,int Dateofyear)
        {
            return Currentyear - Dateofyear;
        }*/
    }
}
