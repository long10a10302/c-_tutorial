using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20_02
{
    public interface IDoctorcs
    {
        int ID { get; }
        string Name { get; set; }
        DateTime BirthDay { get; set; }
        string Speciality { get; set; }
        string Email { get; set; }
        int Rank {  set; }
        
        string this[int index] { get; set; }
        void ShowInfo();
    }
}
