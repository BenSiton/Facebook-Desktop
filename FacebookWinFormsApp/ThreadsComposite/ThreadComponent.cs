using System;
using System.Threading;

namespace FacebookApp.ThreadsComposite
{
    public class ThreadComponent : IThread
    {
        private readonly Thread r_CurrentThread;

        public ThreadComponent(Thread i_Thread)
        {
            r_CurrentThread = i_Thread;
        }

        public void Start()
        {
            r_CurrentThread.Start();
        }

        public void Abort()
        {
            r_CurrentThread.Abort();
        }

        public void Add(IThread i_Thread)
        {
            throw new Exception();
        }

        public void Remove(IThread i_Thread)
        {
            throw new Exception();
        }

        public void Join()
        {
            r_CurrentThread.Join();
        }
    }
}
