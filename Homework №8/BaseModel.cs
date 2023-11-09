namespace Homework__8
{
    public abstract class BaseModel
    {
        protected static long id;
        public long Id
        {
            get;
            set;
        }
        private long TimeId()
        {
            TimeSpan timeSpan = DateTime.Now - DateTime.UnixEpoch;
            return timeSpan.Ticks % 1000000;
        }
        protected BaseModel()
        {
            Id = TimeId();
        }
    }
}
