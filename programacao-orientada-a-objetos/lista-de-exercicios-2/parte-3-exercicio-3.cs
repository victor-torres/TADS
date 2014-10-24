using System;

namespace Parte3Exercicio3
{
	class MainClass
	{
		static String UltimoDia(int mes, int ano) {
			String retorno;
			// Verifica se o mês em questão é fevereiro
			if (mes == 2) {
				// O mês é fevereiro;

				// O ano pode ser bissexto?
				if (ano % 4 == 0) {
					// Sim

					// O ano é múltiplo de 100
					// e não é múltiplo de 400?
					if ((ano % 100 == 0) && (ano % 400 != 0)) {
						// Sim
						retorno = "28";
					} else {
						// Não
						retorno = "29";
					}
				} else {
					// Não
					retorno = "28";
				}
			} else {
				// O mês não é fevereiro;

				// Verifica se o mês é
				// anterior a agosto
				if (mes < 8) {
					// O mês é anterior a agosto
					retorno = (mes % 2) == 0 ? "30" : "31";
				} else {
					// O mês não é anterior a agosto
					retorno = (mes % 2) == 1 ? "30" : "31";
				}
			}
			return retorno;
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma data no formato dd/mm/aaaa:");
			String data = Console.ReadLine ();
			String[] partes = data.Split ('/');
			int mm = int.Parse (partes [1]);
			int aa = int.Parse (partes [2]);
			String dia = UltimoDia (mm, aa);
			Console.WriteLine ("O último dia do mês é " + dia);
		}
	}
}
