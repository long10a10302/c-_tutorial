using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20_02
{
    class Program
    {
        static DoctorManagement management = new DoctorManagement();

        public static object IDoctorcs { get; private set; }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("PLEASE CHOOSE AN OPTION:");
                Console.WriteLine("1. Add new Doctor");
                Console.WriteLine("2. View list of Doctors");
                Console.WriteLine("3. Sort Doctors by Rank");
                Console.WriteLine("4. Delete a Doctor");
                Console.WriteLine("5. Search Doctor By Email");
                Console.WriteLine("6. Exit");
                Console.Write("Option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddDoctor();
                        break;
                    case "2":
                        ViewDoctors();
                        break;
                    case "3":
                        SortDoctors();
                        break;
                    case "4":
                        DeleteDoctor();
                        break;
                    case "5":
                        SearchDoctor();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
        static void AddDoctor()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Birthday: (MM-dd-yyyy): ");
            DateTime birthday;
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.Write("Invalid format! Enter again (MM-dd-yyyy");
            };

            Console.Write("Enter Speciality: ");
            string speciality = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Rank: ");
            int rank;
            while(!int.TryParse(Console.ReadLine(),out rank))
            {
                Console.Write("Invalid rank! Enter again: ");
            }

            Doctor doctor = new Doctor(name, birthday, speciality, email, rank);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter phone {i + 1}: ");
                doctor[i] = Console.ReadLine();
            }

            management.Add(doctor);
            Console.WriteLine("Doctor added successfully!");
        }

        static void ViewDoctors()
        {
            foreach (var doctor in management.GetDoctorcs())
            {
                doctor.ShowInfo();
            }
        }

        static void SortDoctors()
        {
            management.Sort(new SortByRank());
            Console.WriteLine("Doctors sorted by Rank!");
        }
        static void DeleteDoctor()
        {
            Console.Write("Enter Doctor ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                management.Remove(id);
                Console.WriteLine("Doctor deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }

        static void SearchDoctor()
        {
            Console.Write("Enter Email to search: ");
            string email = Console.ReadLine();
            IDoctorcs doctor = management.GetDoctorcs().Find(d => d.Email == email);
            if (doctor != null)
            {
                doctor.ShowInfo();
            }
            else
            {
                Console.WriteLine("Doctor not found!");
            }
        }

    }
}
