using System;
using System.Collections.Generic;

namespace BaiTapTrenLop
{
    internal class Farmhouse
    {
        public Dictionary<int, Coop> coops = new Dictionary<int, Coop>();

        public void AddaCoop()
        {
            Console.Write("Enter Coop ID: ");
            int coopID = int.Parse(Console.ReadLine());
            Console.Write("Enter Coop Name: ");
            string coopName = Console.ReadLine();
            Coop coop = new Coop(coopID, coopName);

            if (!coops.ContainsKey(coop.ID))
            {
                coops[coop.ID] = coop;
                Console.WriteLine($"Coop {coop.ID} - {coop.Name} has been added to the Farmhouse.");
            }
            else
            {
                Console.WriteLine($"A Coop with ID {coop.ID} already exists!");
            }
        }

        public void RemoveaCoop()
        {
            Console.Write("Enter the ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            if (coops.ContainsKey(id))
            {
                coops.Remove(id);
                Console.WriteLine($"Coop with ID {id} has been removed.");
            }
            else
            {
                Console.WriteLine($"Coop with ID {id} not found!");
            }
        }

        public void ToSpeakInChorus()
        {
            Console.WriteLine("\n=== Poultries Speaking in Chorus ===");
            foreach (var coop in coops.Values)
            {
                foreach (object poultry in coop.PoltryList)
                {
                    if (poultry is Poultry p)
                    {
                        p.Speak();
                    }
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("\n=== List of Coops in the Farmhouse ===");
            if (coops.Count == 0)
            {
                Console.WriteLine("The Farmhouse has no Coops yet.");
            }
            else
            {
                foreach (var coop in coops.Values)
                {
                    coop.Contain();
                }
            }
        }
    }
}
