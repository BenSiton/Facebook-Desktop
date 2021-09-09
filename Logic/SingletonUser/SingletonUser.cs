using System;
using FacebookWrapper.ObjectModel;
using Logic.Observer;

namespace Logic
{
    public class SingletonUser
    {
        private SingletonUser()
        {
        }

        public static SingletonUser Instance => sr_Instance;

        public static SingletonSubject PropSingletonSubject { get;} = new SingletonSubject();

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
                    PropSingletonSubject.Notify();
                }
                else
                {
                    throw new Exception("There is already an instance!");
                }
            }
        }
    }
}
