//Console.WriteLine("Hello, World! ok Bharathn");

//string a = Console.WriteLine(value: Console.ReadLine()));

//Console.WriteLine(a);
//Program to show how to print the value of a variable 
global using System;
using System.Net.Http;     //helps in handling all Http 
using System.Threading.Tasks;   //helps in handling threads.

namespace Csharp01
{
    internal class Program
    {

        static void Main(string[] vocab)
        {
            //firstarg second-arg third: arg "fourth arg”  
            Console.WriteLine("hello world");
            Console.WriteLine($"There are {vocab.Length} arguments.");
            //Console.WriteLine($"The Arhuments  are {args}");
            foreach (String words in vocab)
            { 
                Console.WriteLine(words);
            }
            if (vocab.Length < 4)
            {
                WriteLine("Hello");
                WriteLine("dotnet run hello hai howareyou");
            }

            // the below code gives cs4033 error
            //WriteLine("---------------Improving responsiveness of cconsole apps--------------");

            //HttpClient client = new();
            //HttpResponseMessage response = await client.GetAsync($"website name");

            //WriteLine($"Google's home page has {0:N0} bytes");



            //Now resolving the CS4033 error------###
            var url = "Http://www.google.com";
            var task = HttpGetAsync(url);

            string res = task.Result;

            WriteLine($"{res}");

            //Console.ReadKey();
        } //prints the 'helllo bharath'
    }
}




