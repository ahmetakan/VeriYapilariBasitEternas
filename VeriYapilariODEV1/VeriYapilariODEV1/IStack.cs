using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariODEV1
{
    public interface IStack
    {
        void Push(Boncuk _boncuk);

        (int, int) Counter(object[,] Stacks, int rnd, 
                           int top, Boncuk boncuk);

        Boolean IsEmpty();
    }
}
