using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic.Strategy
{
    public class GroupsComparer :IComparer
    {
        public bool ShouldPromote(object i_Group)
        {
            // ReSharper disable once ReplaceWithSingleAssignment.False
            bool valToReturn = false;

            if (SingletonUser.FacebookUser.Groups.Contains(i_Group as Group))
            {
                valToReturn = true;
            }

            return valToReturn;

        }
    }
}
