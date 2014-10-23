using System;

namespace Parte2Exercicio9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase: ");
			String frase = Console.ReadLine ();
			String[] partes = frase.Split (' ');
			foreach (String parte in partes) {
				Console.WriteLine (parte);
			}
		}
	}
}
