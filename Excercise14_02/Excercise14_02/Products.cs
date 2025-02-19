using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise14_02
{
    internal class Products
    {
        private static int Count = 0;
        public string ID { get; private set; }
        public string Name { get; private set; }
        public int Quantity {  get; private set; }

        public Products()
        {
            Count++;
            ID = "Hang" + Count.ToString();
            Name = "No name";
            Quantity = 0;
        }

        public void ShowDetail()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10}", ID, Name, Quantity);
        }

        public void SetDetail(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public void AddQuantity(int addQuantity)
        {
            Quantity += addQuantity;
        }
    }
}
