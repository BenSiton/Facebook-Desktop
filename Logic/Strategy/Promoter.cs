using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic.Strategy
{

    public class Promoter
    {
        public IComparer Comparer { get; set; }

        public Promoter(IComparer i_Comparer)
        {
            Comparer = i_Comparer;
        }

        public void Promote()
        {
/*            int result = 0;

            foreach (Group group in i_Friend.Groups)
            {
                if (SingletonUser.FacebookUser.Groups.Contains(group))
                {
                    result++;
                }
            }

            return result;*/
        }
    }
}
