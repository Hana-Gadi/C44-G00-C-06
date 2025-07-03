using Microsoft.Win32.SafeHandles;
using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6
{
    internal class Program
    {
        #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        public static void passByValue(int x)
        {
            x = 50;
            Console.WriteLine(x);
        }

        public static void passByRef(ref int x)
        {
            x = 50;
            Console.WriteLine(x);
        }

        #endregion

        #region 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        public static void passByValRefType(string name)
        {
            name = "Nada";
            Console.WriteLine(name);

        }

        public static void passByRefRefType(ref string name)
        {
            name = "Nada";
            Console.WriteLine(name);

        }
        #endregion

        #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        public static void calc(int num1, int num2, out int sum,out int sub)
        {
            sum = num1+num2;
            sub = num1 - num2;
        }
        #endregion

        #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        public static int sumOfDigits(int digit)
        {
            int sum = 0;
           string n=Convert.ToString(digit);
            for (int i = 0; i < n.Length; i++)
            {
                sum += Convert.ToInt32(n.Substring(i,1));
            }
            return sum;
        }
        #endregion

        #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        public static bool isPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2;i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        public static void MinMaxArray(ref int[] array, out int min, out int max)
        {
            max = array[0];
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
        }
            #endregion

        #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        public static long factorial(int num) {
        long result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
         }
        #endregion

        #region 8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
        public static string changeChar(string text)
        {
            Console.WriteLine("Enter the letter you want to replase: ");
            char.TryParse(Console.ReadLine(), out char oldLetter);
            Console.WriteLine("You want to replase it to: ");
            char.TryParse(Console.ReadLine(), out char newLetter);
            string result=text.Replace(oldLetter, newLetter);
            return result;

        }
        #endregion

        static void Main(string[] args)
        {
            #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //passing by value create new object and the change in the variables in function no affest the outside variables
            //passing by reference the function parameters and the arguments have the same address so change one of them effect the other
            //int c = 23;
            //passByValue(c);  //50
            //Console.WriteLine(c);  //23

            //passByRef(ref c);  //50
            //Console.WriteLine(c);  //50
            #endregion

            #region 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //Same as question 1 
            //string x = "Sara";
            //passByValRefType(x); //Nada
            //Console.WriteLine(x); // Sara

            //passByRefRefType(ref x); //Nada
            //Console.WriteLine(x); //Nada 
            #endregion

            #region  3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.WriteLine("Please enter the first number: ");
            //int.TryParse(Console.ReadLine(), out int firstNumber);
            //Console.WriteLine("Please enter the second number: ");
            //int.TryParse(Console.ReadLine(), out int secondNumber);
            //int sumation, subtraction;
            //calc(firstNumber,secondNumber,out sumation,out subtraction);
            //Console.WriteLine($"The sum= {sumation}");
            //Console.WriteLine($"The sub= {subtraction}");
            #endregion

            #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int val);
            //int result = sumOfDigits(val);
            //Console.WriteLine($"The sum of the digit is: {result}");
            #endregion

            #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //bool result=isPrime(num);
            //Console.WriteLine($"is {num} a prime number? {result}");
            #endregion
           
            #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = new int[] { 1, 3, 10, 6, 15 };
            //int min, max;
            //MinMaxArray(ref numbers, out min, out max);
            //Console.WriteLine($"The maximum number is: {max}");
            //Console.WriteLine($"The minimum number is: {min}");
            #endregion

            #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //long x=factorial(num);
            //Console.WriteLine($"The factorial of {num} is: {x}");
            #endregion

            #region 8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //Console.WriteLine("Enter the sentence: ");
            //string? s = Console.ReadLine();
            //string text = changeChar(s);
            //Console.WriteLine($"the new sentense is: {text}");
            #endregion

        }
}
}
