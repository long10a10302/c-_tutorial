using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class Duck:Poultry
    {
        public Duck() :base(){ }

        public Duck(int ID, string name) : base(ID, name) { }

        public override void Speak()
        {
            Console.WriteLine("Quac quac quac");
        }


    }
}
