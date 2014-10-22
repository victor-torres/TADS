using System;

namespace Exercicio2
{
	class MainClass
	{
		const double pi = 3.14;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite o raio de um círculo:");
			double raio = double.Parse (Console.ReadLine ());
			Console.WriteLine ("Circunferência = " + (2 * pi * raio).ToString());
			Console.WriteLine ("Área = " + (pi * (raio * raio)).ToString());
		}
	}
}
