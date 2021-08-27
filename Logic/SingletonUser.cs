using System;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class SingletonUser
    {
        private SingletonUser()
        {
        }

        public static SingletonUser Instance => sr_Instance;

        protected virtual void OnUserLoggedInSuccessfully(EventArgs e)
        {
            UserLoggedInSuccessfully?.Invoke(this, null);
        }

        public static event EventHandler<EventArgs> UserLoggedInSuccessfully;

        private static readonly SingletonUser sr_Instance = new SingletonUser();

        private static User s_FacebookUser;

        public static User FacebookUser
        {
            get => s_FacebookUser;
            set
            {
                if (s_FacebookUser == null)
                {
                    s_FacebookUser = value;
                    Instance.OnUserLoggedInSuccessfully(EventArgs.Empty);
                }
                else
                {
                    throw new Exception("There is already an instance!");
                }
            }
        }
    }
}
