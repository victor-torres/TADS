using System;

namespace Parte2Exercicio6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase: ");
			char[] frase = Console.ReadLine ().ToCharArray ();
			for (int i = 1; i <= frase.Length; i++) {
				for (int j = i; j < frase.Length + i; j++) {
					Console.Write (frase [(j % frase.Length)]);
				}
				Console.WriteLine ("");
			}
		}
	}
}
