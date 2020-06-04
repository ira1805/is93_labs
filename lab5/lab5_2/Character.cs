namespace lab5_2
{
    class Character : String
    {
        public string Value
        {
            get => _value;
        }

        public Character(string str) : base(str)
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
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (_value[i] == 'k')
                {
                    count++;
                }
            }
            for (int i = 0; i < n + count; i++)
            {
                if (_value[i] == 'k')
                {
                    string c = _value[i].ToString();
                    _value = _value.Insert(i + 1, c);
                    i++;
                }
            }
        }

        public override string ToString()
        {
            return string.Format(_value);
        }
    }
}
