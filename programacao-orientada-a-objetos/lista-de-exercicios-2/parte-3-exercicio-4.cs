using System;

// Veja mais sobre o modificador de parâmetro "out"
// na documentação do C# na MSDN.
// --> http://msdn.microsoft.com/pt-br/library/ee332485.aspx

namespace Parte3Exercicio4
{
	class MainClass
	{
		static void Idade(string data, out int anos, out int meses) {
			String[] partes = data.Split ('/');
			DateTime dataAtual = DateTime.Today;

			// A princípio, a idade em anos é a diferença entre eles
			anos = dataAtual.Year - int.Parse (partes [2]);
			// Se o mês de aniversário for depois do atual
			if (int.Parse (partes [1]) > dataAtual.Month) {
				// Ainda não completou ano, então tira um
				anos--;
			} 
			// Se o mês de aniversário for o atual
			else if (int.Parse (partes [1]) > dataAtual.Month) {
				// Verifica se ainda não ocorreu o aniversário
				if (int.Parse (partes [0]) > dataAtual.Day) {
					// Ainda não completou ano, então tira um
					anos--;
				}
			}

			// Verifica se o mês de aniversário ainda não passou
			if (int.Parse (partes [1]) > dataAtual.Month) {
				// Calcula a diferença entre os meses
				meses = int.Parse (partes [1]) - dataAtual.Month;
				// Calcula a idade a aprtir da diferença
				meses = 12 - meses;
			}
			// Verifica se o mês de aniversário é exatamente o atual
			else if (int.Parse (partes [1]) == dataAtual.Month) {
				// Verifica se o aniversário é hoje ou já passou
				if (dataAtual.Day >= int.Parse (partes [0])) {
					// Sim
					meses = 0;
				} else {
					// Não
					meses = 11;
				}
			}
			// O mês de aniversário já passou
			else {
				// Calcula a idade
				meses = dataAtual.Month - int.Parse (partes [1]);
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite sua data de nascimento no formato dd/mm/aaaa:");
			String data = Console.ReadLine ();
			int anos;
			int meses;
			Idade (data, out anos, out meses);
			Console.WriteLine ("Sua idade é de " + anos + " anos e " + meses + " meses.");
		}
	}
}
