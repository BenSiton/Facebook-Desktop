namespace FacebookApp.ThreadsComposite
{
    public interface IThread
    {
        void Start();

        void Abort();

        void Add(IThread i_Thread);

        void Remove(IThread i_Thread);

        void Join();
    }
}
