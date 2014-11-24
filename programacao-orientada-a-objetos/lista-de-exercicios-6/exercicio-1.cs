using System;

namespace Exercicio1
{
	class Cliente
	{
		private string nome;
		private string cpf;
		private Cliente socio;
		private double limite;

		public void SetSocio (Cliente c)
		{
			this.socio = c;
			this.socio.socio = this;
		}

		public void SetNome (string n)
		{
			this.nome = n;
		}

		public void SetCpf (string c)
		{
			this.cpf = c;
		}
			
		public void SetLimite (double l)
		{
			this.limite = l;
		}

		public string GetNome ()
		{
			return this.nome;
		}

		public string GetCpf ()
		{
			return this.cpf;
		}

		public double GetLimite ()
		{
			double l = this.limite;
			if (this.socio != null) {
				l += this.socio.limite;
			}

			return l;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Exercício 1");
		}
	}
}
