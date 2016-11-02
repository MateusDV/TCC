using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Prova
	{
		public static int ID_Ativ { get; private set; }

		public static String Nome { get; private set; }

		public static String Descricao { get; private set; }

		public static int ID_Professor { get; private set; }

		public static DataTable Tabela { get; set; }
		
		public static void select(int id_professor)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_CONSULTAR_TODOS";
			string[] param = { "ID_PROFESSOR" };
			string[] valor = { id_professor.ToString() };

			ds = conexao.executarProcedure(sql, param, valor);

			Tabela = ds.Tables[0];
		}

		public static void select(string campo, string valor)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_CONSULTAR_ESPECIFICO";
			string[] param = { "CAMPO", "VALOR" };
			string[] valores = { campo, valor };

			ds = conexao.executarProcedure(sql, param, valores);

			Tabela = ds.Tables[0];
		}
	}
}
