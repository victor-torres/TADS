using System;
using System.Collections.Generic;

namespace Parte2Exercicio12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma sequência de números separados por vírgula:");
			String frase = Console.ReadLine ();
			String[] partes = frase.Split (',');
			int soma = 0;
			foreach (String parte in partes) {
				soma += int.Parse (parte);
			}
			Console.WriteLine ("Soma = " + soma);
		}
	}
}
