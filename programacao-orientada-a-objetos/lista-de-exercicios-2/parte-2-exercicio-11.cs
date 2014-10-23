using System;

// Nota:
//
// Na codificação Unicode UTF-8, caracteres acentuados
// podem ser contados como dois.
//
// Veja "Contando Caracteres" (em inglês)
// no blog de desenvolvimento do Twitter.
// --> https://dev.twitter.com/overview/api/counting-characters
//
// Veja também a classe Normalize do C# na página da MSDN.
// --> http://msdn.microsoft.com/pt-br/library/8eaxk1x2(v=vs.110).aspx

namespace Parte2Exercicio8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase: ");
			String frase = Console.ReadLine ();
			frase = frase.Normalize ();
			String[] partes = frase.Split (' ');
			foreach (String parte in partes) {
				Console.Write (parte.Length);
			}
			Console.WriteLine ();
		}
	}
}
