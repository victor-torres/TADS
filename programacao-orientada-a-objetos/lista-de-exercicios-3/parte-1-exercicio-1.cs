using System;

namespace Parte1Exercicio1
{
	class Circulo
	{
		// Atributos da classe
		private double raio;
		private const double pi = 3.14;

		// Construtor padrão
		public Circulo ()
		{
			this.raio = 0.0;
		}

		// Cosntrutor com um parâmetro
		public Circulo (double raio)
		{
			this.raio = raio;
		}

		// Método set
		public void setRaio (double raio)
		{
			this.raio = raio;
		}

		// Método get
		public double getRaio ()
		{
			return this.raio;
		}

		// Método que retorna a área
		public double area ()
		{
			return pi * (raio * raio);
		}

		// Método que retorna a circunferência
		public double circunferencia ()
		{
			return 2.0 * pi * raio;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			// Cria dois Círculos
			Circulo r1 = new Circulo ();
			Circulo r2 = new Circulo (1.5);

			// Mostra os valores dos raios dos círculos
			Console.WriteLine ("Mostra os valores dos raios dos círculos");
			Console.WriteLine (r1.getRaio ());
			Console.WriteLine (r2.getRaio ());

			// Define o valor do raio do primeiro círculo
			r1.setRaio (2.0);

			// Mostra os valores dos raios dos círculos novamente
			Console.WriteLine ("Mostra os valores dos raios dos círculos novamente");
			Console.WriteLine (r1.getRaio ());
			Console.WriteLine (r2.getRaio ());

			// Mostra os valores das áreas dos círculos
			Console.WriteLine ("Mostra os valores das áreas dos círculos");
			Console.WriteLine (r1.area ());
			Console.WriteLine (r2.area ());

			// Mostra os valores das circunferências dos círculos
			Console.WriteLine ("Mostra os valores das circunferências dos círculos");
			Console.WriteLine (r1.circunferencia ());
			Console.WriteLine (r2.circunferencia ());
		}
	}
}
