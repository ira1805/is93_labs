using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class MyString
    {
		public char[] arrgs;
		public int count = 0;
		public MyString(char[] line = null)
		{
			arrgs = line;
		}
		public int СharCount(MyString arr, char c)
		{
			int k = 0;
			for (int j = 0; j < arr.count; j++)
			{
				if (arr.arrgs[j] == c)
				{
					k += 1;
				}
			}
			return k;
		}
		public void outputString()
		{
			for (int i = 0; i < arrgs.Length; i++)
			{
				if (arrgs[i] == default(char))
					break;
				Console.Write(arrgs[i]);
			}
		}
		public void GetStr(char[] arr)
		{
			arrgs = arr;
			for (int i = 0; i < 1000; i++)
			{
				if (arr[i] == default(char))
					break;
				count++;
			}
		}
		~MyString()
		{
		}
	}
}
