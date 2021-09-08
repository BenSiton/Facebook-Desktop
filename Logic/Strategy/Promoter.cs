using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class Promoter
    {
        public IComparer Comparer { get; set; }

        public Promoter(IComparer i_comparer)
        {
            Comparer = i_comparer;
        }

        public bool ShouldPromote(object i_Obj)
        {
            bool result = false;

            if (Comparer.isContained(i_Obj))
            {
                result = true;
            }

            return result;
        }

        public int Promote(object i_Obj)
        {
            int result = 0;

            foreach (object obj in i_Obj as dynamic)
            {
                if (ShouldPromote(obj))
                {
                    result++;
                }
            }

            return result;
        }
    }
}