namespace lab5_2
{
    class Digits : String
    {
        public string Value
        {
            get => _value;
        }

        public Digits(string str) : base(str)
        {
            _value = str;
        }

        public override int GetLength()
        {
            return base.GetLength();
        }

        public override void AddItem()
        {
            int n = GetLength();
            for(int i = 0; i < 2*n; i++)
            {
                string c = _value[i].ToString();
                _value = _value.Insert(i + 1, c);
                i++;
            }
        }

        public override string ToString()
        {
            return string.Format(_value);
        }
    }
}

