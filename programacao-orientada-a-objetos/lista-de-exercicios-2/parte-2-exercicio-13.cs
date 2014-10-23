using System;

namespace Parte2Exercicio13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Resultado: ");
			for (int i = 1; i <= 30; i++) {
				Console.Write (i + " ");
				if (i % 3 == 0) {
					Console.Write ((3 * i - 3) + " ");
				}
			}
		}
	}
}
