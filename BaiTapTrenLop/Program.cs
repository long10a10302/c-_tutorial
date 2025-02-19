using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmhouse fm = new Farmhouse();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== FARMHOUSE MENU ===");
                Console.WriteLine("1. Add a new Coop");
                Console.WriteLine("2. Remove a Coop");
                Console.WriteLine("3. Add a new Poultry");
                Console.WriteLine("     a. Add a new Chicken");
                Console.WriteLine("     b. Add a new Duck");
                Console.WriteLine("4. Remove a Poultry ");
                Console.WriteLine("5. Show all Poultry");
                Console.WriteLine("6. Poultries reply in chorus");
                Console.WriteLine("7. Exit");
                Console.Write("Chosse an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        fm.AddaCoop();
                        break;
                    case 2:
                        fm.RemoveaCoop();
                        break;
                    case 3:
                        Console.WriteLine("Available Coops:");
                        foreach (var coop in fm.coops)
                        {
                            Console.WriteLine($"ID: {coop.Key}, Name: {coop.Value.Name}");
                        }

                        Console.Write("Enter coop ID to add poultry: ");
                        int selectedCoopID = int.Parse(Console.ReadLine());

                        if (fm.coops.ContainsKey(selectedCoopID))
                        {
                            Coop selectedCoop = fm.coops[selectedCoopID];
                            Console.WriteLine("a. Add a new Chicken");
                            Console.WriteLine("b. Add a new Duck");
                            char poultryChoice = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                            if (poultryChoice == 'a')
                            {
                                selectedCoop.AddaChicken();
                            }
                            else if (poultryChoice == 'b')
                            {
                                selectedCoop.AddaDuck();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Coop ID.");
                        }
                        break;
                    case 4:
                        Console.Write("Enter coop ID to remove poultry from: ");
                        int poultryCoopId = int.Parse(Console.ReadLine());
                        if (fm.coops.ContainsKey(poultryCoopId))
                        {
                            Console.Write("Enter poultry ID to remove: ");
                            int poultryID = int.Parse(Console.ReadLine());
                            fm.coops[poultryCoopId].RemovePoultry(poultryID);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Coop ID");
                        }
                        break;
                    case 5:
                        fm.Show();
                        break;
                    case 6:
                        fm.ToSpeakInChorus();
                        break;
                    case 7:
                        Console.WriteLine("Exit program. Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again!");
                        break;
                }
            }
        }
    }
    
}
