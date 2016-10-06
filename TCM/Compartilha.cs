using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    public class Compartilha
    {
        //pegar no login e usar em outros lugares
		private static string id;
		private static string nome;
		private static string cargo;

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public string Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}
	}
}
