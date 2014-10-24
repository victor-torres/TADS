using System;

namespace Parte3Exercicio1
{
	class MainClass
	{
		static String Iniciais (String s) {
			String[] partes = s.Split (' ');
			String iniciais = "";
			foreach (String parte in partes) {
				iniciais += parte.ToCharArray ()[0] + " ";
			}
			return iniciais;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite seu nome completo:");
			String nomeCompleto = Console.ReadLine ();
			Console.WriteLine ("As iniciais do seu nome são:");
			Console.WriteLine (Iniciais(nomeCompleto));
		}
	}
}
