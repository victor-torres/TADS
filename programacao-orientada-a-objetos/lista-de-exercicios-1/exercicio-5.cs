using System;

namespace Exercicio5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite um valor monetário:");
			String[] valor = Console.ReadLine ().Split(',');
			Console.WriteLine (valor [0] + " reais e " + valor [1] + " centavos");
		}
	}
}
