using System;

namespace Parte2Exercicio1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase: ");
			String frase = Console.ReadLine ();
			String[] partes = frase.Split (' ');
			for (int i = 0; i < partes.Length; i++) {
				for (int j = i; j < partes.Length; j++) {
					Console.Write (partes [j] + " ");
				}
				Console.WriteLine ("");
			}
		}
	}
}
