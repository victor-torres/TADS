using System;

namespace Parte1Exercicio4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite o horário no formato hh:mm");
			String[] horario;
			int hh, mm;
			try {
				horario = Console.ReadLine ().Split(':');
				hh = int.Parse (horario [0]) % 12;
				mm = int.Parse (horario [1]) % 60;
			} catch (Exception e) {
				Console.WriteLine ("O horário informado é inválido.");
				return;
			}
			int anguloA = mm * 6;										// A cada minuto o ponteiro anda 6 graus
			int anguloB = ((hh * 60) + mm) / 2;							// A cada hora o ponteiro anda 30 graus
			int diferenca = anguloA - anguloB;
			diferenca = diferenca < 0 ? diferenca * -1 : diferenca;		// Se for um número negativo, inverte.
			diferenca = diferenca > 180 ? 360 - diferenca : diferenca;	// Se for o o maior ângulo, inverte.
			Console.WriteLine ("Menor ângulo entre os ponteiros " + diferenca + " graus");
		}
	}
}
