//using System.console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("____________Understanding Selection Statments_________\n");

        WriteLine("________Branching with the if statement__________\n");
        WriteLine($"The if statement determines which branch to follow by evaluating a \nBoolean expression. If the expression is true, then the block executes. \nThe else block is optional, and it executes \nif the if expression is false. The if statement can be nested.");

        WriteLine("*****Syntax****");
        //WriteLine($"if(expression)");
        int a = 10;
        int b = 15;
        int c = 20;
        //int d = 30;

        if (a > b)
        {
            WriteLine('b');
        }
        else if (a > c)
        {
            WriteLine("c");
        }
        else
        {
            WriteLine("The else block");
        }
        // prints else block

        //example 2

        string pasword = "Bharath";
        WriteLine($"{pasword}");

        if (pasword.Length < 10)
        {
            WriteLine("The password length is less than 18 char");
        }
        else
        {
            WriteLine("The password is good");
        }


        WriteLine("\n\n");
        WriteLine("_________________Pattern matching with if statement____________\n");
        object o = "3";
        int j = 5;
        //int i = 0;
        if(o is int i)
        {
            WriteLine($"{i} x {j} = {i * j}");
        }
        else
        {
            WriteLine("o is not an int so it cannot multiply!");
        }

        // o as an int

        object z = 3;
        int k = 5;
        //int i = 0;
        if (z is int l) // is operator is "checks if the result of an expression is compatible with a given type"
        {
            WriteLine($"{l} x {k} = {l * k}\n");
        }
        else
        {
            WriteLine("o is not an int so it cannot multiply!");
        }



        WriteLine("______________Branching with Switch Statement________\n");
   
        int number = Random.Shared.Next(1, 7);
        WriteLine($"My random number is {number}");
        switch (number)
        {
            case 1:
                WriteLine("One");
                break; // jumps to end of switch statement
            case 2:
                WriteLine("Two");
                goto case 1;
            case 3: // multiple case section
            case 4:
                WriteLine("Three or four");
                goto case 1;
            case 5:
                goto A_label;
            default:
                WriteLine("Default");
                break;
        } // end of switch statement
        WriteLine("After end of switch");
    A_label:
        WriteLine($"After A_label");


    }
}