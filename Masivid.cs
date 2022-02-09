using System;
using System.Collections.Generic;
using System.Text;

namespace C_programm
{
	class Masivid
	{
		static void Main(string[] args)
		{

			int[] arvut = new int[5];
			Console.WriteLine("Vvedi 5 chisel:");
			int i;
			for (i = 0; i < arvut.Length; i++) // andmed massiivisse
			{
				arvut[i] = int.Parse(Console.ReadLine()); 
			}
			int summa = 0;
			int korrutis = 1;
			//foreach (int arv in arvut)//massiiv ekraanile
			//{
			//	summa += arv;
			//	korrutis *= arv;
			//}
			for (i = 0; i < arvut.Length; i++)
			{
				summa += arvut[i];
				korrutis *= arvut[i];
			}
			Console.WriteLine($"Summa={summa}");
			Console.WriteLine($"Korrutis={korrutis}");
			Console.WriteLine($"Keskmine={summa/arvut.Length,4}");

			Console.ReadLine();

			//Loo  juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile.
			//Random rnd = new Random();
			//int N = rnd.Next(1, 10);
			//int M = rnd.Next(1, 10);
			//Console.WriteLine($"N={N}");//2
			//Console.WriteLine($"M={M}");//6
			//if (N>M)
			//{
			//	int abi = N;
			//	N = M;
			//	M = abi;
			//}
			//int[] NM = new int[M - N + 1];//2,3,4,5,6
			//for (int j = N; j < M+1; j++)//N=2 j=2 on vaja 0(-N)
			//{
			//	NM[j-N] = j;
			//	Console.WriteLine(j * j);//NM[j]^2, Math.Power(NM[j],2)
			//}




			// 
			//Random rnd = new Random();
			//int[] arvud = new int[10];
			//for (int i = 0; i < arvud.Length; i++) // arvud.Length=10
			//{
			//	arvud[i] = rnd.Next(1, 100);
			//}
			//foreach (int arv in arvud)
			//{
			//	Console.Write($" {arv,4} ");
			//}
			//Console.WriteLine();
			//string[] nimed = new string[5] { "Anna","Olga","Mark","Timur","Jegor"};
			//int a=0;
			//do
			//{
			//	Console.Write("Jrkorde number(tavaline inimene) 1-5:"); //1,2,3,4,5
			//	try
			//	{
			//		a = int.Parse(Console.ReadLine());
			//	}
			//	catch (Exception e)
			//	{

			//		Console.WriteLine(e);
			//	}

			//} while (a<1 || a>5);
			//Console.WriteLine(nimed[a-1]);


			//Console.ReadLine();
		}
	}
}
