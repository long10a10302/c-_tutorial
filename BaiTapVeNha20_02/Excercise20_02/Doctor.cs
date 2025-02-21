using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20_02
{
    public class Doctor : IDoctorcs
    {
        private static int nextId = 1;
        private int id;
        private int rank;
        public string[] phoneList = new string[3];

        public int ID => id;
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
        public int Rank { set { rank = value; } }

        public Doctor(string name, DateTime birthday, string speciality, string email, int rank)
        {
            id = nextId++;
            Name = name;
            BirthDay = birthday;
            Speciality = speciality;
            Email = email;
            this.Rank = rank;
        }

        public int getRank()
        {
            return rank;
        }
        public string this[int index] {
            get => phoneList[index];
            set => phoneList[index] = value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, BirthDay: {BirthDay.ToShortDateString()},Speciality: {Speciality}, Email: {Email}");
            for (int i = 0; i < phoneList.Length; i++)
            {
                Console.WriteLine($"Phone {i + 1}: {phoneList[i]}");
            }
        }
    }
}
