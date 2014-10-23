using System;

namespace Parte2Exercicio14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine ("Tabuada de " + i);
				for (int j = 1; j <= 10; j++) {
					Console.WriteLine (j + " x " + i + " = " + j * i);
				}
				Console.WriteLine ();
			}
		}
	}
}
