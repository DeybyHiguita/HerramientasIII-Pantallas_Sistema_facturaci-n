using System;
namespace Core
{
    public abstract class DataGeneral
    {
        private object result;
        public object Run()
        {
            Process();
            return result;
        }
        protected void SetResult(object value)
        {
            result = value;
        }
        protected abstract void Process();
    }
}
