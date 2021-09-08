using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic.Strategy
{
    class PagesComparer : IComparer
    {
        public bool ShouldPromote(Object i_Page)
        {
            // ReSharper disable once ReplaceWithSingleAssignment.False
            bool valToReturn = false;

            if(SingletonUser.FacebookUser.LikedPages.Contains(i_Page as Page))
            {
                valToReturn = true;
            }

            return valToReturn;
        }
    }
}
