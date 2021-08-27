using System.Collections.Generic;

namespace FacebookApp.ThreadsComposite
{
    public class ThreadComposite : IThread
    {
        private readonly IList<IThread> r_CollectionOfItems;

        public ThreadComposite()
        {
            r_CollectionOfItems = new List<IThread>();
        }

        public void Start()
        {
            foreach (IThread thread in r_CollectionOfItems)
            {
                thread.Start();
            }
        }

        public void Abort()
        {
            foreach (IThread thread in r_CollectionOfItems)
            {
                thread.Join();
                thread.Abort();
            }
        }

        public void Add(IThread i_Thread)
        {
            r_CollectionOfItems.Add(i_Thread);
        }

        public void Remove(IThread i_Thread)
        {
            r_CollectionOfItems.Remove(i_Thread);
        }

        public void Join()
        {
            foreach (IThread thread in r_CollectionOfItems)
            {
                thread.Join();
            }
        }
    }
}
