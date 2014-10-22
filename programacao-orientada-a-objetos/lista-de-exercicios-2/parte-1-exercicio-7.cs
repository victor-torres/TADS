using System;

namespace Parte1Exercicio7
{
	class MainClass
	{
		static String nomeDoMes (int mes)
		{
			String nome;
			switch (mes) {
				case 1:
					nome = "janeiro";
					break;
				case 2:
					nome = "fevereiro";
					break;
				case 3:
					nome = "março";
					break;
				case 4:
					nome = "abril";
					break;
				case 5:
					nome = "maio";
					break;
				case 6:
					nome = "junho";
					break;
				case 7:
					nome = "julho";
					break;
				case 8:
					nome = "agosto";
					break;
				case 9:
					nome = "setembro";
					break;
				case 10:
					nome = "outubro";
					break;
				case 11:
					nome = "novembro";
					break;
				case 12:
					nome = "dezembro";
					break;
				default: 
					nome = "mês inválido";
					break;
			}
			return nome;
		}
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma data no formato dd/mm/aaaa");
			String[] data = Console.ReadLine ().Split('/');
			Console.WriteLine ("A data é " + data[0] + " de " + nomeDoMes(int.Parse (data[1])) + " de " + data[2]);
		}
	}
}
