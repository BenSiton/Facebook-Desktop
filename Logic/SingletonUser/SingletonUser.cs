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

        public static UserSubject UserSubject { get;} = new UserSubject();

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
                    UserSubjectNotify();
                }
                else
                {
                    throw new Exception("There is already an instance!");
                }
            }
        }

        public static void UserSubjectNotify()
        {
            UserSubject.Notify();
        }
    }
}
