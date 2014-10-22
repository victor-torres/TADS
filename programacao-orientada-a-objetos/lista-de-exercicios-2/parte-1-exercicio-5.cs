using System;
using System.Collections.Generic;

namespace Parte1Exercicio5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite quatro valores inteiros");
			List<int> valores = new List<int>();
			for (int i = 0; i < 4; i++) {
				int aux = int.Parse (Console.ReadLine ());
				foreach (int valor in valores) {
					if (valor == aux) {
						Console.WriteLine ("Você não pode inserir valores iguais.");
						return;
					}
				}
				valores.Add (aux);
			}
			valores.Sort ();
			Console.WriteLine ("Maior valor: " + valores[3]);
			Console.WriteLine ("Menor valor: " + valores[0]);
			Console.WriteLine ("A soma do segundo maior valor com o segundo menor: " + (valores [1] + valores [2]));
		}
	}
}
