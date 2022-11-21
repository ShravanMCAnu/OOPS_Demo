using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Demo
{
    public interface IInterface2:IInterface    //Using Multiple Interfaces
    {
        public int Bankbalance { get; set; }
        void Balance();
    }
}
