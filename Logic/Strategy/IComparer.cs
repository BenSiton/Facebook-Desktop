using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public interface IComparer
    {
        bool isContained(object i_Obj);
    }
}
