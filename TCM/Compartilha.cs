using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    public class Compartilha
    {
        private static string nivel; //pegar no login e usar em outros lugares
		private static string id;
		private static string nome;

		public string Nivel
		{
			get { return nivel; }
			set { nivel = value; }
		}

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
	}
}
