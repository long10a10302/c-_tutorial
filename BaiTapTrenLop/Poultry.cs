using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class Poultry
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
        public Poultry()
        {
            ID = 0;
            Name = string.Empty;
        }
        public Poultry(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Day la lop gia cam");
        }

        public void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
        }
    }

    
}
