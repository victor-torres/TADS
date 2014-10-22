using System;
using System.Collections.Generic;

namespace Parte1Exercicio6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite dez valores inteiros.");
			List<int> valores = new List<int> ();
			for (int i = 0; i < 10; i++) {
				valores.Add (int.Parse (Console.ReadLine ()));
			}
			valores.Sort ();
			Console.WriteLine ("O maior valor é " + valores[9] + " e o menor valor é " + valores[0]);
		}
	}
}
