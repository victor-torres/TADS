using System;

namespace Exercicio3
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
		private Cliente cliente;
		private ListaClientes proximoCliente;

		public void ListarClientes ()
		{
			Console.WriteLine ("Nome - Cpf - Sócio - Limite");

			ListaClientes posicao = this;
			while (posicao.cliente != null) {
				Console.Write (posicao.cliente.GetNome () + " - ");
				Console.Write (posicao.cliente.GetCpf () + " - ");
				Console.Write (posicao.cliente.GetSocio () + " - ");
				Console.Write (posicao.cliente.GetLimite ().ToString ());
				Console.WriteLine ("");

				posicao = posicao.proximoCliente;
			}
		}

		public void AdicionarCliente (Cliente c)
		{
			ListaClientes posicao = this;
			while (posicao.cliente != null) {
				posicao = posicao.proximoCliente;
			}
			posicao.cliente = new Cliente();
			posicao.cliente = c;
			posicao.proximoCliente = new ListaClientes ();
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Exercício 3");
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
