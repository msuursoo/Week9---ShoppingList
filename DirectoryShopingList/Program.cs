using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\samples";
            Console.WriteLine("Enter directory name 'shoppingList':");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter filename 'myshoppingList.txt':");
            string fileName = Console.ReadLine();



            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exists");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

                Console.WriteLine("Kaust on edukalt loodud");

            }

        }

        }
    }

    

