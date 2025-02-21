using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20_02
{
    class DoctorManagement
    {
        private List<IDoctorcs> doctorList = new List<IDoctorcs>();

        public void Add(IDoctorcs doctor)
        {
            doctorList.Add(doctor);
        }

        public void Remove(int doctorId)
        {
            IDoctorcs doctorToRemove = doctorList.Find(doc => doc.ID == doctorId);
            if(doctorToRemove != null)
            {
                doctorList.Remove(doctorToRemove);
            }
        }
        public void Sort(IComparer<IDoctorcs> comparer)
        {
            doctorList.Sort(comparer);
        }
        public List<IDoctorcs> GetDoctorcs()
        {
            return doctorList;
        }
    }
}
