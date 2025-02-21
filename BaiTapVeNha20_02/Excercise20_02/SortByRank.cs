using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20_02
{
    public class SortByRank : IComparer<IDoctorcs>
    {
        public int Compare(IDoctorcs x, IDoctorcs y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Both doctors must be non-null.");
            }
            Doctor d1 = (Doctor)x;
            Doctor d2 = (Doctor)y;
            return d1.getRank().CompareTo(d2.getRank());
        }
    }


}
