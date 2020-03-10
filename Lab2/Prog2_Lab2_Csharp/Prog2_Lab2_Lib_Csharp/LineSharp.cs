using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Lab2_Lib_Csharp
{
    class LineSharp
    {
		public char[] line { get => this.line; set => this.line = value; }

		public LineSharp(string input)
		{
			for (int i = 0; i < line.Length; i++)
			{
				line[i] = input[i];
			}
		}

		public char[] Get()
		{
			return line;
		}

		public int Count()
		{
			return line.Length;
		}

		public bool FindSame(string series)
		{
			if (line.Length != series.Length)
			{
				return false;
			}
			for (int i = 0; i < line.Length; i++)
			{
				if (line[i] != series[i])
				{
					return false;
				}
			}
			return true;
		}
		
		public void FindAndReplace(char find, char replace)
		{
			for (int i = 0; i < line.Length; i++)
			{
				if (line[i] == find)
				{
					line[i] = replace;
				}
			}
		}
	}
}
