using System;

namespace Parte1Exercicio1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite quatro valores inteiros");
			int[] valores = new int[] { 0, 0, 0, 0 };
			int media = 0;
			for (int i = 0; i < valores.Length; i++) {
				valores[i] = int.Parse (Console.ReadLine());
				media += valores[i];
			}
			media /= valores.Length;
			Console.WriteLine (media);
			Console.WriteLine ("Números menores que a média:");
			foreach (int valor in valores) {
				if (valor < media) {
					Console.WriteLine (valor);
				}
			}
			Console.WriteLine ("Números maiores que a média:");
			foreach (int valor in valores) {
				if (valor >= media) {
					Console.WriteLine (valor);
				}
			}
		}
	}
}
