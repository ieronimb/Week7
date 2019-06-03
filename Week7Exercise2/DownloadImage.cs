using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Week7Exercise2
{
    class DownloadImage
    {
        static void Main(string[] args)
        {
            /*2.Write a program that downloads a file from Internet (e.g.Ninja image) and stores it the current directory. Find in Google how to download files in C#. 
            Be sure to catch all exceptions and to free any used resources in the finally block.*/

            Console.WriteLine("Enter the URL adress to download the image:" +
            "\nExample: https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOVnQfLvcUpa7kEgJXMm_PI90ITY1M2fkv9h8esvCF03GQw7hp");
            string imageURL = Console.ReadLine();
            Console.WriteLine("Enter the name of the file:");
            string fileName = Console.ReadLine();
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(imageURL, fileName);
                Console.WriteLine("Download complete. Please check the project's ->bin->Debug folder");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"Either the adress {imageURL} or the file name {fileName} is null");
            }
            catch (WebException)
            {
                Console.WriteLine($"Either the adress {imageURL} is invalid, the file name {fileName} is null or an error occured while downloading file");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }            
            Console.ReadKey();
        }
    }
}
