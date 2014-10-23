using System;

namespace Parte2Exercicio8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase: ");
			String frase = Console.ReadLine ();
			String[] partes = frase.Split (' ');
			Console.WriteLine (partes.Length);
		}
	}
}
