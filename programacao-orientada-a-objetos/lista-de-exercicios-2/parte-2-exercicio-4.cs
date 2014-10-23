using System;

namespace Parte2Exercicio1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Resultado: ");
			int valor = 1;
			for (int i = 0; i < 10; i++) {
				valor += i;
				Console.Write (" " + valor);
			}
			Console.WriteLine ("");
		}
	}
}
