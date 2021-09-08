using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PagesComparer : IComparer
    {
        public bool isContained(object i_Page)
        {
            bool result = false;

            if(SingletonUser.FacebookUser.LikedPages.Contains(i_Page as Page))
            {
                result = true;
            }

            return result;
        }
    }
}
