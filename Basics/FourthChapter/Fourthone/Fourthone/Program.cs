internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n----------------Welcome to operators---------------------\n");
        
        //declaring a two values a,b
        int x= 5;
        int y = 10;
        int resultofAdding = x + y ;
        int resultOfMul = x*y;
        WriteLine($"The addition of {x} and {y} is {resultofAdding}");
        WriteLine($"The Multiplication of {x} and {y} is {resultOfMul:N1}\n");

        WriteLine("\n\n______________Exploring Uninary operator______________________\n\n");
        int a = 3;
        int b = a++;
        WriteLine($"a is {a} and b is {b}"); //expecting b value as 4
        //but the value of b is 3 because ++ represent post operand that means it 1st assignes and then increments


        //Testing post operands (c++) with pre operands (++c)
        WriteLine("Checking the Post and Pre Operator");

        int c = 10;
        int d = c++;
        WriteLine($"The value of c is {c} and the value of d is {d}");

        int e = 20;
        int f = ++e;
        WriteLine($"The value of e is {e} and the value of f is {f}\n\n");


        WriteLine("_____________________Exploring Binary Operators__________________\n");

        WriteLine($"e + f = {e + f}"); 
        WriteLine($"e - f = {e - f}"); 
        WriteLine($"e * f = {e * f}"); 
        WriteLine($"e / f = {e / f}"); 
        WriteLine($"e % f = {e % f}");

        double g = 11.0;
        WriteLine($"g is {g:N1}, f is {f} ");
        WriteLine($" g/f = {g/f}\n\n");


        WriteLine("__________________Assignment Operators______________\n");

        WriteLine("Its simply = ");
        int p = 10;
        WriteLine($"P *= p is {p *= p}");
        WriteLine($"p /= p is {p /= p}\n\n");


        WriteLine("________________Exploring Logical Operators_____________\n");

        bool a1 = true;
        bool b1 = false;
        WriteLine($"AND  | a1    | b1    ");
        WriteLine($"a1    | {a1 & a1,-2} | {a1 & b1,-2} ");
        WriteLine($"b1    | {b1 & a1,-2} | {b1 & b1,-2} ");
        WriteLine();
        WriteLine($"OR   | a1     | b1    ");
        WriteLine($"a1    | {a1 | a1,-2} | {a1 | b1,-2} ");
        WriteLine($"b1    | {b1 | a1,-2} | {b1 | b1,-2} ");
        WriteLine();
        WriteLine($"XOR  | a1     | b1    ");
        WriteLine($"a1    | {a1 ^ a1,-2} | {a1 ^ b1,-2} ");
        WriteLine($"b1    | {b1 ^ a1,-2} | {b1 ^ b1,-2} \n");


        WriteLine("_________________Exploring conditional logical operators___________________\n");

        WriteLine("Conditional operators are like logical operators but here we use two i.e &&, instead of &");

        static bool Dostuff()
        {
            WriteLine("I am doing good stuff");
            return true;
        }

        WriteLine();
        WriteLine($"a & DoStuff() = {a1 & Dostuff()}");
        WriteLine($"b & DoStuff() = {b1 & Dostuff()}\n"); //&

        //&&
        WriteLine();
        WriteLine($"a && DoStuff() = {a1 && Dostuff()}");
        WriteLine($"b && DoStuff() = {b1 && Dostuff()}");
        WriteLine("Note the before b, The text is not printed ");
        WriteLine("Conditional Logical operators are Short-Circuiting and Makes the application more Efficient\n\n");


        WriteLine("______________________Exploring bitwise and binary shift operators ___________\n");
        WriteLine("Bitwise operators affets bits in number Binary shift \nOperators can perform some common arthemic calculations \nmuch faster than traditional calculation");






















    }
}