#include<iostream>
using namespace std;
namespace New
{
	void Counter(int &a)
	{
		int Ai;
		for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
		{
			Ai = (a & (1 << mask)) ? 1 : 0;
				if (Ai == 1)
				{
					for (int i = 0; i < mask+1; i++)
					{
						a = a ^ (1 << i);
					}
					break;
				}
		}
	}
	int Summa_Bit(int a, int b)
	{
		int Ai, Bi; int s = 0, k = 0;
		for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++)
		{
			Ai = (a & (1 << mask))?1:0;
			Bi = (b & (1 << mask))?1:0;
			if (Ai + Bi + k == 1)
			{
				s = s | (1 << mask);
				k = 0;
			}
			else
			{
				if (Ai + Bi + k ==2)
				{
					k = 1;
				}
				else
				{
					if (Ai + Bi + k > 2)
					{
						k=1;
						s = s | (1 << mask);
					}
				}
			}
			Ai = 0;
			Bi = 0;
		}
		return s;
	}
}