using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Lab2_Lib_Csharp
{
    public class TextSharp
	{
	private LineSharp[] text;

	public TextSharp(string[] input)
		{
			this.text = new LineSharp[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				this.text[i] = new LineSharp(input[i]);
			}
		}

	public void AddLine(int index, string insert)
		{
			for (int i = text.Length - 1; i > index; i--)
			{
				text[i + 1] = text[i];
			}
			text[index] = new LineSharp(insert);
		}

	public void RemoveLine(int index)
		{
			for (int i = index; i < text.Length; i++)
			{
				text[index] = text[index + 1];
			}
		}

	public void CleanAll()
		{
			
		}

		public int CountAll()
		{
			int count = 0;
			for (int i = 0; i < text.Length; i++)
			{
				count += text[i].Count();
			}
			return count;
		}

		public int FindCount(string series)
		{
			int count = 0;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i].FindSame(series) == true)
				{
					count++;
				}
			}
			return count;
		}

		public void FindAndReplaceAll(char find, char replace)
		{
			for (int i = 0; i < text.Length; i++)
			{
				text[i].FindAndReplace(find, replace);
			}
		}
	}


}
