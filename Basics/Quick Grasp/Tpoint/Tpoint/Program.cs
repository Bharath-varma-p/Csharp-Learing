internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a value :");
        int i;
        i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nThe value you entered is {i}");
        Console.WriteLine("hello");

        WriteLine($"\n _______________The decision making___________\n ");

        WriteLine(@"1. if.
2. else if.
3. Nesterd if statements.
4. Swwitch.
5. Nesterd switch 
                    ");

        if (i < 20)
        {
            WriteLine($"The value is less than 20 i.e {i}");
        }
        else
        {
            WriteLine($"The value you entered is {i}");
        }
        WriteLine($"\nEnter the value from (A-F) \n");
        char grade = Convert.ToChar(ReadLine());

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
            case 'C':
                Console.WriteLine("Well done");
                break;
            case 'D':
                Console.WriteLine("You passed");
                break;
            case 'F':
                Console.WriteLine("Better try again");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }
        Console.WriteLine("Your grade is  {0}", grade);
        WriteLine("Press any key");

        Console.ReadLine();

        WriteLine("\n________________Loops_____________\n");
        //While loop start.
        WriteLine("\n %% While  and Syntax %%");
        WriteLine(@"while(condition) {
   statement(s);
}");
        WriteLine("||||||||||||||||||||");

        int a1 = 10;

        /* while loop execution */
        while (a1 < 20)
        {
            Console.WriteLine("value of a: {0}", a1);
            a1++;
        }
        //While Loop Ends.
        ReadLine();
        WriteLine("\n");
        WriteLine("\n %% For and Syntax %%\n");
        //For loop starts.
        WriteLine(@"for ( init; condition; increment ) {
   statement(s);
}");
        WriteLine("||||||||||||||||||||");
        for (int a = 10; a < 20; a = a + 1)
        {
            Console.WriteLine("value of a: {0}", a);
        }
        WriteLine("\n");
        //Loop Ends Here.
        Console.ReadLine();

        WriteLine("\n %% Do While and Syntax %%\n");
        WriteLine(@"do {
   statement(s);
} while( condition );");
        WriteLine("||||||||||||||||||||");
        int a2 = 10;

        /* do loop execution */
        do
        {
            Console.WriteLine("value of a: {0}", a2);
            a2 = a2 + 1;
        }
        while (a2 < 20);



        WriteLine("\n%%Nesterd loops%%\n");
        WriteLine(@"do {
   statement(s);
   do {
      statement(s);
   }
   while( condition );
}
while( condition );");
        //Do while Start.

        int i, j;

        for (i = 2; i < 100; i++)
        {
            for (j = 2; j <= (i / j); j++)
                if ((i % j) == 0) break; // if factor found, not prime
            if (j > (i / j)) Console.WriteLine("{0} is prime", i);
        }


    }
}