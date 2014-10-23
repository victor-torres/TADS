using System;

namespace Parte2Exercicio6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase: ");
			String frase = Console.ReadLine ();
			for (int i = 1; i <= frase.Length; i++) {
				Console.WriteLine (i + " - " + frase);
			}
		}
	}
}
