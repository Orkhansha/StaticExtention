
using ClassworkStaticExtention.Models;
using ClassworkStaticExtention.Models.Helpers;
using System;

namespace ClassworkStaticExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //Car car2 = new Car();

            //Person person1 = new Person();
            //Person person2 = new Person();
            //Person person3 = new Person();

            //Car.Sum();

            //string word = "Salam P130";
            //string name = "Orxan";

            ////name.CheckDigit();

            ////var result= Extention.CheckDigit(word);
            ////var result = word.CheckDigit();
            //var result1 = word.CheckString(@"\d");
            //var result2 = word.CheckString(@"[A-Z]");

            //Console.WriteLine(result2);

            int num1 = 5;
            int num2 = 10;

            var result = num1.SumNumbers(num2);
            Console.WriteLine(result);




        }
    }
}
