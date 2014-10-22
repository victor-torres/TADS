using System;

namespace Exercicio3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite as notas dos três primeiros bimestres:");
			float nota1 = float.Parse (Console.ReadLine());
			float nota2 = float.Parse (Console.ReadLine());
			float nota3 = float.Parse (Console.ReadLine());
			float nota4 = (60 - ((nota1 * 2) + (nota2 * 2) + (nota3 * 3))) / 3;
			Console.WriteLine ("Nota para passar = " + nota4);
		}
	}
}
