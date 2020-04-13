using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_
{
    class MyString
    {
		public virtual int Length() { return 0; }
	    public virtual void Sort() { }
    }

    class Uppercas: MyString
    {
		private string m_data;

		public Uppercas(string s)
		{
			m_data = s;
		}

		public override int Length()
		{
			return m_data.Length;
		}

		public override void Sort()
		{
			string s = m_data;
			int i, j;
			char temp;

			char[] charS = s.ToCharArray();

			for (i = 0; i < charS.Length - 1; i++)
				for (j = 0; j < charS.Length - i - 1; j++)
					if (charS[j] > charS[j + 1])
					{
						temp = charS[j];
						charS[j] = charS[j + 1];
						charS[j + 1] = temp;
					}

			s = new string(charS);

			Console.WriteLine(" sort:  " + s);
		}
	}

	class Lowercase : MyString
	{
		private string m_data;

		public Lowercase(string s)
		{
			m_data = s;
		}

		public override int Length()
		{
			return m_data.Length;
		}

		public override void Sort()
		{
			string s = m_data;
			int i, j;
			char temp;

			char[] charS = s.ToCharArray();

			for (i = 0; i < charS.Length - 1; i++)
				for (j = 0; j < charS.Length - i - 1; j++)
					if (charS[j] < charS[j + 1])
					{
						temp = charS[j];
						charS[j] = charS[j + 1];
						charS[j + 1] = temp;
					}

			s = new string(charS);

			Console.WriteLine(" sort:  " + s);
		}
	}
}
