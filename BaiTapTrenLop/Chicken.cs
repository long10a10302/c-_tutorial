using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class Chicken:Poultry
    {
        public Chicken() : base() {
            
        }

        public Chicken(int ID, string name) : base(ID, name) { }

        public override void Speak()
        {
            Console.WriteLine("O o O oo");
        }
    }
}
