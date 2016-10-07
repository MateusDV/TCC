using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Professor
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Professor { get; private set; }

		public static String Nome { get; private set; }

		public static String Sexo { get; private set; }

		public static String RG { get; private set; }

		public static String CPF { get; private set; }

		public static String Rua { get; private set; }

		public static int Num { get; private set; }

		public static String Bairro { get; private set; }

		public static String Cep { get; private set; }

		public static String Cidade { get; private set; }

		public static String Estado { get; private set; }

		public static String Telefone { get; private set; }

		public static String Celular { get; private set; }

		public static String Email { get; private set; }

		public static String Senha { get; private set; }

		public static bool Ativo { get; private set; }

		public static DataTable Tabela { get; private set; }


		public static int insert(String nome, String sexo, String rg, String cpf, String rua, int numero, String bairro, String cep, String cidade, String estado, String fone, String cel, String email, String senha)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string nomeProc = "USP_PROF_INSERIR";
			string[] campos = { "NOME", "SEXO", "RG", "CPF", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL", "SENHA", "ATIVO" };
			string[] valores = { nome, sexo, rg, cpf, rua, numero.ToString(), bairro, cep, cidade, estado, fone, cel, email, senha, "1" };

			ds = conexao.executarProcedure(nomeProc, campos, valores);
			return (int) ds.Tables[0].Rows[0][0];
		}
	}
}
