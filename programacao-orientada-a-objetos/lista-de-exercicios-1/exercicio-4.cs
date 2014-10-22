using System;

namespace Exercicio4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite sua data de nascimento:");
			short ano = short.Parse ( Console.ReadLine ().Split('/')[2]);
			Console.WriteLine ("Em 31/12/2013 você terá " + (2013 - ano) + " anos");
		}
	}
}
