using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week7
{
    class Week7Exercise1
    {
            /*
            1. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
            Find in MSDN how to use System.IO.File.ReadAllText(...). Be sure to catch all possible exceptions and print user-friendly error messages.
            */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file's full path:");
            string fullPath = Console.ReadLine();
            try
            {
                string readFile = File.ReadAllText(fullPath);
                Console.WriteLine($"The file's content is:\n{readFile}");
            }          
             catch (ArgumentException)
            {
                Console.WriteLine($"The entered file path ({fullPath}) is not correct");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file {fullPath} was not found");
            }            
            catch(NotSupportedException)
            {
                Console.WriteLine($"The file {fullPath} is not supported");
            }
            Console.ReadKey();
        }
    }
}
