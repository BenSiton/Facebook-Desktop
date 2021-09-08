using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Strategy
{
    public interface IComparer
    {
        bool ShouldPromote(object i_Obj);
    }
}
