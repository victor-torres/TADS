using System;

namespace Parte2Exercicio3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Resultado: ");
			for (int i = 1; i <= 10; i++) {
				Console.Write (" " + ((i % 2) == 1 ? i : i * -1));
			}
			Console.WriteLine ("");
		}
	}
}
