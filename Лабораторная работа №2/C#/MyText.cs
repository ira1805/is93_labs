using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringLibrary;

namespace TextLibrary
{
	public class MyText
    {
		public int count;
		public MyString[] arrgs = new MyString[100];
		public void AddStr_2(MyString text//Add the string
		{
			arrgs[count++] = text;
		}
		public void DeleteStr_2(int a)//Delete the string
		{
			for (int i = a - 1; i < count; i++)
			{
				arrgs[i] = arrgs[i + 1];
			}
			count--;
		}
		public void DeleteText_2()// Erase all the text
		{
			for (int i = 0; i < count; i++)
			{
				arrgs[i] = new MyString();
			}
			count = 0;
		}
		public void MinStr_2(char[] a)// Find min string
		{
			int min = arrgs[0].count;
			int i_m = 0;
			for (int i = 0; i < count; i++)
			{
				if (arrgs[i].count < min)
				{
					min = arrgs[i].count;
					i_m = i;
				}
			}
			int i_2 = 0;
			for (int j = 0; j < arrgs[i_m].count; j++)
			{
				a[i_2] = arrgs[i_m].arrgs[j];
				i_2++;
			}
		}
		public void FirstChars_2(char[] a)//Find string of fisrsts chars each sentencense
		{
			int j = 0;
			for (int i = 0; i < count; i++)
			{
				a[j] = arrgs[i].arrgs[0];
				j++;
			}
		}
		public int CharCountInTextAndStr_2(char c)// Find noumber one char in each sentencense
		{
			int s = 0;
			for (int i = 0; i < count; i++)
			{
				int Counte = arrgs[i].СharCount(arrgs[i], c);
				s += Counte;
			}
			return s;
		}
	}
}
