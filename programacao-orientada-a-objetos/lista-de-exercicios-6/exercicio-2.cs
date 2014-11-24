using System;

namespace Exercicio2
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

		public string GetSocio ()
		{
			string n = null;
			if (this.socio != null) {
				n = this.socio.nome;
			} else {
				n = "Não possui";
			}
			return n;
		}
	}

	class ListaClientes
	{
		private Cliente[] clientes = new Cliente[50];

		public void ListarClientes ()
		{
			Console.WriteLine ("Nome - Cpf - Sócio - Limite");

			foreach (Cliente cliente in clientes)
			{
				if (cliente != null) 
				{
					Console.Write (cliente.GetNome () + " - ");
					Console.Write (cliente.GetCpf () + " - ");
					Console.Write (cliente.GetSocio () + " - ");
					Console.Write (cliente.GetLimite ().ToString ());
					Console.WriteLine ("");
				}
			}
		}

		public void AdicionarCliente (Cliente c)
		{
			int i = 0;
			Cliente posicao = clientes [i];
			while (posicao != null) {
				posicao = clientes [++i];
			}
			clientes[i] = c;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Exercício 2");
			ListaClientes lista = new ListaClientes ();

			Cliente clientea = new Cliente ();
			clientea.SetNome ("Fulano A");
			clientea.SetCpf ("12345");
			clientea.SetLimite (1000.00);
			lista.AdicionarCliente (clientea);

			Cliente clienteb = new Cliente ();
			clienteb.SetNome ("Fulano B");
			clienteb.SetCpf ("54321");
			clienteb.SetLimite (2000.00);
			clienteb.SetSocio (clientea);
			lista.AdicionarCliente (clienteb);

			lista.ListarClientes ();
		}
	}
}
