using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class GroupsComparer : IComparer
    {
        public bool isContained(object i_Group)
        {
            bool result = false;

            if (SingletonUser.FacebookUser.Groups.Contains(i_Group as Group))
            {
                result = true;
            }

            return result;
        }
    }
}
