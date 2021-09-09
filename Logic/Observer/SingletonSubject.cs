using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Observer
{
    public class SingletonSubject
    {
        public static event EventHandler<EventArgs> UserLoggedInSuccessfully;

        protected virtual void OnUserLoggedInSuccessfully(EventArgs e)
        {
            UserLoggedInSuccessfully?.Invoke(this, null);
        }
        public void Notify()
        {
            OnUserLoggedInSuccessfully(EventArgs.Empty);
        }

        public void Attach(IObserverUserLogin i_Observer)
        {
            UserLoggedInSuccessfully += i_Observer.Update;
        }

        public void Detach(IObserverUserLogin i_Observer)
        {
            UserLoggedInSuccessfully -= i_Observer.Update;
        }

    }

}
