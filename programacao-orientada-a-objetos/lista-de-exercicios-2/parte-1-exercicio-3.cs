using System;

namespace Parte1Exercicio3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite três valores inteiros");
			int maior = 0;
			int menor = 0;
			for (int i = 0; i < 3; i++) {
				int aux = int.Parse (Console.ReadLine ());
				maior = aux > maior || menor == 0 ? aux : maior;
				menor = aux < menor || menor == 0 ? aux : menor;
			}
			Console.WriteLine ("A soma do maior número com o menor número é " + (maior + menor).ToString () + "."); 
		}
	}
}
