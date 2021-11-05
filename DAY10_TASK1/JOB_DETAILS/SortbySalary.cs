using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_DETAILS
{
    class SortbySalary : IComparer<Job>
    {
        public int Compare(Job x, Job y)
        {
            return x.Sal.CompareTo(y.Sal);
        }


    }
}
