using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;


namespace variables
{
     class Variables
    {
        static void Main(string[] args)
        {
            //int age = 22;
            //float height = 5.9F;
            //double weight = 72.45;
            //char grade = 'A';
            //bool isPassed = true;
            //string name = "Venkatesh";

            //Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Weight: {weight}, Grade: {grade}, Passed: {isPassed}");




            //Imagine you’re building a small HR System for your company.

            //string employeeName = "Ravi Kumar";
            //int employeeId = 1021;
            //double salary = 45000.50;
            //bool isPermanent = true;
            //Console.WriteLine($"Employee {employeeName} (ID: {employeeId}) earns {salary} and permanent status is {isPermanent}");

            //  //    Variables are memory containers that store values.

            //     Data type decides what type of data can be stored.

            //      Naming should be meaningful and follow rules.

            //       //C# is strongly typed, meaning every variable must have a defined type.
            //       



            //string studentname = "VENKY";
            //int rollnumber = 62;
            //int clas=10;

            //Console.WriteLine($"student name :{studentname}");
            //Console.WriteLine($"student rollno is :{rollnumber}");
            //Console.WriteLine($"Student is in  class :{ clas}");






            //now im trying to write a program which includes all of these


            int age = 25;
            float height = 5.10f;
            double weight = 72.45;
            char grad= 'A';
            bool passed = true;
            string name = "ram";

            Console.WriteLine($"age of the student is :{age}");
            Console.WriteLine($"Height of the student is :{height}");
            Console.WriteLine($"weight of the student is :{weight}");
            Console.WriteLine($"grade for student is :{grad}");
            Console.WriteLine($"student has passed in sem : {passed}");
            Console.WriteLine($"Name of the student is :{name}");


            //now we will see about operators 

            int a = 10, b = 25;
            int sum = a + b;
            //here + is an operator and it adds a and b

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Remainder: " + (a % b));


























        }

     }
}
