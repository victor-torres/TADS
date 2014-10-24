using System;

namespace Parte3Exercicio5
{
	class MainClass
	{
		static int Soma (int inicio, int fim) {
			int soma = 0;
			for (int i = inicio; i <= fim; i++) {
				soma += i;
			}
			return soma;
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Este programa soma todos os números de um intervalo.");
			Console.WriteLine ("Digite o início do intervalo:");
			int inicio = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite o fim do intervalo:");
			int fim = int.Parse (Console.ReadLine ());
			Console.WriteLine ("A soma dos números de " + inicio + " a " + fim + " é igual a " + Soma(inicio, fim));
		}
	}
}
