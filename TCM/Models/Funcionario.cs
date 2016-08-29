using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Funcionario
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Funcionario { get; private set; }

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

		public static String Cargo { get; private set; }

		public bool login(String email, String senha, out String id, out String tipo)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			Compartilha comp = new Compartilha();

			string sql = String.Format("SELECT * FROM FUNCIONARIO WHERE EMAIL = '{0}' AND SENHA = '{1}'", email, senha);

			ds = conexao.executarSQL(sql);

			int conta = ds.Tables[0].Rows.Count;

			if (conta > 0)
			{
				id = ds.Tables[0].Rows[0]["ID_FUNCIONARIO"].ToString();
				tipo = "funcionario";
				comp.Nome = ds.Tables[0].Rows[0]["NOME"].ToString();
				return true;
			}
			else
			{
				id = "";
				tipo = "";
				return false;
			}
		}

		public static void select(String id)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = string.Format("SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = {0}", id);

			ds = conexao.executarSQL(sql);

			ID_Funcionario = (int) ds.Tables[0].Rows[0]["ID_FUNCIONARIO"];
			Nome = ds.Tables[0].Rows[0][1].ToString();
			Sexo = ds.Tables[0].Rows[0][2].ToString();
			RG = ds.Tables[0].Rows[0][3].ToString();
			CPF = ds.Tables[0].Rows[0][4].ToString();
			Rua = ds.Tables[0].Rows[0][5].ToString();
			Num = (int) ds.Tables[0].Rows[0][6];
			Bairro = ds.Tables[0].Rows[0][7].ToString();
			Cep = ds.Tables[0].Rows[0][8].ToString();
			Cidade = ds.Tables[0].Rows[0][9].ToString();
			Estado = ds.Tables[0].Rows[0][10].ToString();
			Telefone = ds.Tables[0].Rows[0][11].ToString();
			Celular = ds.Tables[0].Rows[0][12].ToString();
			Email = ds.Tables[0].Rows[0][13].ToString();
			Senha = ds.Tables[0].Rows[0][14].ToString();
			Cargo = ds.Tables[0].Rows[0]["CARGO"].ToString();
		}
	}
}
