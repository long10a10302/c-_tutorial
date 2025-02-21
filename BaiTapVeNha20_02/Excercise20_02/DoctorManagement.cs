using Excercise20_02;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250220.Assignment16
{
    public class DoctorManagement
    {
        private List<IDoctorcs> doctorList = new List<IDoctorcs>();


        public void Add(IDoctorcs doctor)
        {
            doctorList.Add(doctor);
            Console.WriteLine("Doctor added successfully");
        }

        public void Remove(IDoctorcs doctor)
        {
            if (doctorList.Contains(doctor))
            {
                doctorList.Remove(doctor);
                Console.WriteLine($"Doctor with ID {doctor.ID} has been removed.");
            }
            else
            {
                Console.WriteLine("Doctor not found");
            }
        }

        public IDoctorcs FindDoctorById(int id)
        {
            foreach (IDoctorcs doctor in doctorList)
            {
                if (doctor.ID == id) return doctor;
            }
            return null;
        }

        public void Sort(IComparer<IDoctorcs> comp)
        {
            doctorList.Sort(comp);
            Console.WriteLine("Doctors sorted successfully");
        }

        public void DisplayAll()
        {
            foreach (IDoctorcs doctor in doctorList)
            {
                doctor.ShowInfo();
            }
        }

        public IDoctorcs SearchByEmail(string email)
        {
            foreach (IDoctorcs doctor in doctorList)
            {
                if (doctor.Email == email)
                {
                    return doctor;
                }
            }
            return null;
        }
        public List<IDoctorcs> GetDoctorcs()
        {
            return doctorList;
        }

        public bool IsEmpty()
        {
            return doctorList.Count == 0;
        }
    }
}