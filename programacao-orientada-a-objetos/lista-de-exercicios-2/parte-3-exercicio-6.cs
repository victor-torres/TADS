using System;

namespace Parte3Exercicio6
{
	class MainClass
	{
		static int MDC(int x, int y) {
			// Organiza o maior e o menor dos números
			int menor, maior;
			menor = x < y ? x : y;
			maior = x > y ? x : y;

			// Calcula o MDC através do método das divisões sucessivas
			int resto = -1;
			while (resto != 0) {
				resto = maior % menor;
				maior = menor;
				menor = resto;
			}

			return maior;
		}

		static int MMC(int x, int y) {
			// Calcula o MMC segundo o Algoritmo Euclidiano
			// a partir do MDC entre os números
			int resultado = (x * y) / MDC (x, y);
			return resultado;
		}

		public static void Main (string[] args)
		{
			int primeiroNumero, segundoNumero;
			Console.WriteLine ("Digite dois números para que sejam calculados seus respectivos MDC e MMC:");
			Console.WriteLine ("Digite o primeiro número:");
			primeiroNumero = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite o segundo número:");
			segundoNumero = int.Parse (Console.ReadLine ());
			Console.WriteLine ("O MDC entre " + primeiroNumero + " e " + segundoNumero + " é " + MDC(primeiroNumero, segundoNumero));
			Console.WriteLine ("O MMC entre " + primeiroNumero + " e " + segundoNumero + " é " + MMC(primeiroNumero, segundoNumero));
		}
	}
}
