using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class Coop
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public ArrayList arrayPoultry;

        public Coop()
        {
            ID = 0;
            Name = string.Empty;
            arrayPoultry = new ArrayList();
        }

        public Coop(int Id, String name)
        {
            ID = Id;
            Name = name;
            arrayPoultry = new ArrayList();
        }

        public ArrayList PoltryList
        {
            get { return arrayPoultry; }
        }

        public void Contain()
        {
            Console.WriteLine("Danh sach gia cam ");
            foreach (Poultry item in arrayPoultry)
            {
                item.Display();
            }
        }

        public void AddaChicken()
        {
            Console.WriteLine("Enter a Chicken ID: "); 
            int chickenID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Chicken Name: ");
            string nameChicken = Console.ReadLine();
            Chicken ck = new Chicken(chickenID, nameChicken);
            arrayPoultry.Add(ck);
        }

        public void AddaDuck()
        {
            Console.WriteLine("Enter a Duck ID: ");
            int duckID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Duck Name: ");
            string nameDuck = Console.ReadLine();
            Duck duck = new Duck(duckID, nameDuck);
            arrayPoultry.Add(duck);
        }
        public void RemovePoultry(int id)
        {
            for (int i = 0; i < arrayPoultry.Count; i++)
            {
                if (((Poultry)arrayPoultry[i]).ID == id)
                {
                    arrayPoultry.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
