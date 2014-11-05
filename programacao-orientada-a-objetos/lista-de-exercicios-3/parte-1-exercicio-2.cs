using System;

namespace Parte1Exercicio2
{
	class NumeroRacional
	{
		// Atributos privados
		private int numerador;
		private int denominador;

		// Construtor padrão
		public NumeroRacional ()
		{
			this.numerador = 0;
			this.denominador = 1;
		}

		// Construtor com dois parâmetros
		public NumeroRacional (int numerador, int denominador)
		{
			this.numerador = numerador;
			this.denominador = denominador;
		}

		// Método set do numerador
		public void setNumerador (int numerador)
		{
			this.numerador = numerador;
		}

		// Método set do denominador
		public void setDenominador (int denominador)
		{
			this.denominador = denominador;
		}

		// Método get do numerador
		public int getNumerador ()
		{
			return this.numerador;
		}

		// Método get do denominador
		public int getDenominador ()
		{
			return this.denominador;
		}

		// Método para calcular o MDC entre dois números
		private static int MDC(int x, int y) {
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

		// Método para calcular o MMC entre dois números
		private static int MMC(int x, int y) {
			// Calcula o MMC segundo o Algoritmo Euclidiano
			// a partir do MDC entre os números
			int resultado = (x * y) / MDC (x, y);
			return resultado;
		}

		// Método de adição
		public NumeroRacional adicao (NumeroRacional a, NumeroRacional b)
		{
			// Cria novo objeto
			NumeroRacional resultado = new NumeroRacional ();

			// Verifica se os denominadores são iguais
			if (a.getDenominador () == b.getDenominador ()) {
				// Soma os numeradores e conserva-se o denominador
				resultado.setNumerador (a.getNumerador () + b.getNumerador ());
				resultado.setDenominador (a.getDenominador ());
			} else {
				// Calcula-se o MMC entre os denominadores
				int mmc = MMC (a.getDenominador (), b.getDenominador ());

				// Divide-se o MMC pelo denominador de cada número racional e
				// multiplica-se pelo seu numerador
				int numeradorA = (mmc / a.getDenominador ()) * a.getNumerador ();
				int numeradorB = (mmc / b.getDenominador ()) * b.getNumerador ();

				// Soma os numeradores resultantes da operação anterior
				resultado.setNumerador (numeradorA + numeradorB);

				// Define o denominador do resultado como sendo o MMC
				resultado.setDenominador (mmc);
			}
			return resultado;
		}

		// Método adicionar
		public NumeroRacional adicionar (NumeroRacional b)
		{
			return this.adicao (this, b);
		}

		// Método de subtração
		public NumeroRacional subtracao (NumeroRacional a, NumeroRacional b)
		{
			// Cria novo objeto
			NumeroRacional resultado = new NumeroRacional ();

			// Verifica se os denominadores são iguais
			if (a.getDenominador () == b.getDenominador ()) {
				// Soma os numeradores e conserva-se o denominador
				resultado.setNumerador (a.getNumerador () + b.getNumerador ());
				resultado.setDenominador (a.getDenominador ());
			} else {
				// Calcula-se o MMC entre os denominadores
				int mmc = MMC (a.getDenominador (), b.getDenominador ());

				// Divide-se o MMC pelo denominador de cada número racional e
				// multiplica-se pelo seu numerador
				int numeradorA = (mmc / a.getDenominador ()) * a.getNumerador ();
				int numeradorB = (mmc / b.getDenominador ()) * b.getNumerador ();

				// Subtrai os numeradores resultantes da operação anterior
				resultado.setNumerador (numeradorA - numeradorB);

				// Define o denominador do resultado como sendo o MMC
				resultado.setDenominador (mmc);
			}
			return resultado;
		}

		// Método subtrair
		public NumeroRacional subtrair (NumeroRacional b)
		{
			return this.subtracao (this, b);
		}

		// Método multiplicação
		public NumeroRacional multiplicacao (NumeroRacional a, NumeroRacional b)
		{
			NumeroRacional resultado = new NumeroRacional ();
			resultado.setNumerador (a.getNumerador () * b.getNumerador ());
			resultado.setDenominador (a.getDenominador () * b.getDenominador ());
			return resultado;
		}

		// Método multiplicar
		public NumeroRacional multiplicar (NumeroRacional b)
		{
			return this.multiplicacao (this, b);
		}

		// Método divisão
		public NumeroRacional divisao (NumeroRacional a, NumeroRacional b)
		{
			NumeroRacional resultado = new NumeroRacional ();
			resultado.setNumerador (a.getNumerador () * b.getDenominador ());
			resultado.setDenominador (a.getDenominador () * b.getNumerador ());
			return resultado;
		}

		// Método dividir
		public NumeroRacional dividir (NumeroRacional b)
		{
			return this.divisao (this, b);
		}

		// Método simplificar
		public NumeroRacional simplificar ()
		{
			// Calcula o MDC entre o numerador e o denominador
			int mdc = MDC (this.numerador, this.denominador);
			// Cria novo objeto
			NumeroRacional resultado = new NumeroRacional ();
			resultado.setNumerador (this.numerador / mdc);
			resultado.setDenominador (this.denominador / mdc);
			return resultado;
		}

	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			NumeroRacional a, b, c, d;
			// 1/7 + 3/7 = 5/7
			a = new NumeroRacional (1, 7);
			b = new NumeroRacional (3, 7);
			c = a.adicionar (b);
			Console.WriteLine ("1/7 + 3/7 = " + c.getNumerador () + "/" + c.getDenominador ());

			// 2/4 + 1/2 = 1/1
			a = new NumeroRacional (2, 4);
			b = new NumeroRacional (1, 2);
			c = a.adicionar (b);
			Console.WriteLine ("2/4 + 1/2 = " + c.getNumerador () + "/" + c.getDenominador ());

			// Simplificar resultado anterior
			d = c.simplificar ();
			Console.WriteLine (c.getNumerador () + "/" + c.getDenominador () + " -> " + d.getNumerador () + "/" + d.getDenominador ());

			// 2/4 * 1/2 = 2/8
			a = new NumeroRacional (2, 4);
			b = new NumeroRacional (1, 2);
			c = a.multiplicar (b);
			Console.WriteLine ("2/4 * 1/2 = " + c.getNumerador () + "/" + c.getDenominador ());

			// 8/2 / 2/1 = 8/4
			a = new NumeroRacional (8, 2);
			b = new NumeroRacional (2, 1);
			c = a.dividir (b);
			Console.WriteLine ("8/2 / 2/1 = " + c.getNumerador () + "/" + c.getDenominador ());

			// Simplificar resultado anterior
			d = c.simplificar ();
			Console.WriteLine (c.getNumerador () + "/" + c.getDenominador () + " -> " + d.getNumerador () + "/" + d.getDenominador ());
		}
	}
}
