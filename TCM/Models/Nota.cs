using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Nota
	{
		public static DataTable Tabela_Atrib { get; private set; }

		public static DataTable Tabela_Not_Atrib { get; private set; }

		public static int insert(int id_prova, int id_aluno, int list, int read, int speak, int perf)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_NOTA_ATRIBUIR";
			string[] param = { "ID_PROVA", "ID_ALUNO", "LIST", "READ", "SPEAK", "PERF" };
			int[] valorTemp = { id_prova, id_aluno, list, read, speak, perf };
			string[] valor = valorTemp.Select(x => x.ToString()).ToArray();

			ds = conexao.executarProcedure(sql, param, valor);

			return (int) ds.Tables[0].Rows[0][0];
		}

		public static void select(int id_aluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_NOTA_JA_ATRIB";
			string[] param = { "ID_ALUNO" };
			string[] valor = { id_aluno.ToString() };

			ds = conexao.executarProcedure(sql, param, valor);

			Tabela_Atrib = ds.Tables[0];
		}

		public static void select_disp(int id_aluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_NOTA_DISP";
			string[] param = { "ID_ALUNO" };
			string[] valor = { id_aluno.ToString() };

			ds = conexao.executarProcedure(sql, param, valor);

			Tabela_Not_Atrib = ds.Tables[0];
		}
	}
}
