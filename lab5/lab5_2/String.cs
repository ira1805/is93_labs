using System.Linq;

namespace lab5_2
{
    abstract class String
    {
        public string _value;

        public String(string str)
        {
            _value = str;
        }

        public virtual int GetLength()
        {
            return _value.Count();
        }

        public abstract void AddItem();
    }
}
