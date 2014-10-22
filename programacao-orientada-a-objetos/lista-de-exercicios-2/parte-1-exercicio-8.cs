using System;

namespace Parte1Exercicio8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite dois valores inteiros separados por um operador +, -, * ou /");
			String operacao = Console.ReadLine ();
			char operador;
			if (operacao.Contains ("+")) {
				operador = '+';
			} else if (operacao.Contains ("-")) {
				operador = '-';
			} else if (operacao.Contains ("*")) {
				operador = '*';
			} else if (operacao.Contains ("/")) {
				operador = '/';
			} else {
				Console.WriteLine ("Expressão incorreta.");
				return;
			}
			int parte1, parte2;
			String[] partes = operacao.Split (operador);
			parte1 = int.Parse (partes [0]);
			parte2 = int.Parse (partes [1]);
			int resultado;
			switch (operador) {
				case '+': 
					resultado = parte1 + parte2;
					break;
				case '-': 
					resultado = parte1 - parte2;
					break;
				case '*': 
					resultado = parte1 * parte2;
					break;
				case '/': 
					resultado = parte1 / parte2;
					break;
				default:
					resultado = 0;
					break;
			}
			Console.WriteLine ("O resultado da operação é " + resultado);
		}
	}
}
