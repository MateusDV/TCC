using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Periodo_Aluno
	{
		public static int ID_Aluno { get; private set; }

		public static int ID_Periodo { get; private set; }

		public static DateTime Cadastro { get; private set; }

		public static DataTable tabela { get; private set; }

		public static int insert(int ID_al, int ID_per)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string sql = "USP_PERIODO_ALUNO_INSERIR";
				string[] campos = { "ID_ALUNO", "ID_PERIODO" };
				string[] valores = { ID_al.ToString(), ID_per.ToString() };

				ds = conexao.executarProcedure(sql, campos, valores);
				return (int)ds.Tables[0].Rows[0][0];
			}
			catch (Exception) { return 0; }
		}

		public static void select(string idAluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PERIODO_ALUNO_CONSULTAR";
			string[] campos = { "ID_ALUNO" };
			string[] valores = { idAluno };

			ds = conexao.executarProcedure(sql, campos, valores);

			ID_Aluno = (int) ds.Tables[0].Rows[0][0];
			ID_Periodo = (int) ds.Tables[0].Rows[0][1];
			Cadastro = (DateTime) ds.Tables[0].Rows[0][2];
		}
	}
}
