using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Knowledgecheck2sl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("How many T-shirts do you want to add?");
                int numberOfRecords;
                while (!int.TryParse(Console.ReadLine(), out numberOfRecords) || numberOfRecords < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of T-shirts to add.");
                }


                var recordList = new List<TShirt>();


                for (int i = 0; i < numberOfRecords; i++)
                {

                    // In this loop, populate the object's properties using Console.ReadLine()
                    var tShirt = new TShirt();

                    Console.WriteLine($"Record {i + 1}");

                    Console.WriteLine("Enter Name: ");
                    tShirt.Name = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    decimal price;
                    while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid price.");
                    }
                    tShirt.Price = price;

                    Console.WriteLine("Enter Size: ");
                    tShirt.Size = Console.ReadLine();

                    Console.WriteLine("Enter Material: ");
                    tShirt.Material = Console.ReadLine();

                    Console.WriteLine("Enter Design: ");
                    tShirt.Design = Console.ReadLine();

                    Console.WriteLine("Enter SleeveType: ");
                    tShirt.SleeveType = Console.ReadLine();

                    recordList.Add(tShirt);
                }

                // Print out the list of records using Console.WriteLine()

                Console.WriteLine("Do you want to display the added T-shirt(s)? (y/n)");
                string displayInventory = Console.ReadLine();

                if (displayInventory.ToLower() == "y")
                {
                    Console.WriteLine("The T-shirt(s) added to the records are: ");
                    foreach (var tShirt in recordList)
                    {
                        Console.WriteLine($"Name: {tShirt.Name}");
                        Console.WriteLine($"Price: {tShirt.Price}");
                        Console.WriteLine($"Size: {tShirt.Size}");
                        Console.WriteLine($"Material: {tShirt.Material}");
                        Console.WriteLine($"Design: {tShirt.Design}");
                        Console.WriteLine($"Sleeve Type: {tShirt.SleeveType}");
                        Console.WriteLine();
                    }
                }
                else if (displayInventory.ToLower() == "n")
                {
                    Console.WriteLine("No records will be displayed.");
                    Console.WriteLine();
                }
                else
                {
                    while (displayInventory.ToLower() != "y" && displayInventory.ToLower() != "n")
                    {
                        Console.WriteLine("Invalid input. Please answer y to display the T-Shirt(s) or n to not display.");
                        displayInventory = Console.ReadLine().ToLower();
                    }
                    if (displayInventory.ToLower() == "y")
                    {
                        Console.WriteLine("The T-shirt(s) added to the records are: ");
                        foreach (var tShirt in recordList)
                        {
                            Console.WriteLine($"Name: {tShirt.Name}");
                            Console.WriteLine($"Price: {tShirt.Price}");
                            Console.WriteLine($"Size: {tShirt.Size}");
                            Console.WriteLine($"Material: {tShirt.Material}");
                            Console.WriteLine($"Design: {tShirt.Design}");
                            Console.WriteLine($"Sleeve Type: {tShirt.SleeveType}");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No records will be displayed.");
                        Console.WriteLine();
                    }


                }
                Console.WriteLine("Press enter to add additional T-shirts or type exit to close the program.");
                Console.WriteLine();

            }
            while (Console.ReadLine().ToLower() != "exit");
        }
    }


}
