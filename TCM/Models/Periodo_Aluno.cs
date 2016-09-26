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
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Aluno { get; private set; }

		public static int ID_Periodo { get; private set; }

		public static int insert(int ID_al, int ID_per)
		{
			ClasseConexao conexao = new ClasseConexao();

			string sql = String.Format("INSERT INTO PERIODO_ALUNO VALUES('{0}', '{1}')", ID_al, ID_per);

			return conexao.executarSQLNonQuery(sql);
		}

		public static void select(string idAluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string query = string.Format("SELECT * FROM PERIODO_ALUNO WHERE ID_ALUNO = '{0}'", idAluno);

			ds = conexao.executarSQL(query);
			ID_Aluno = (int)ds.Tables[0].Rows[0][0];
			ID_Periodo = (int)ds.Tables[0].Rows[0][1];
		}

		public static int update(int idPeriodo, int idAluno)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();

				string query = string.Format("UPDATE PERIODO_ALUNO SET ID_CURSO = '{0}' WHERE ID_ALUNO = '{1}'", idPeriodo, idAluno);

				return conexao.executarSQLNonQuery(query);
			}
			catch (Exception) { return 0; }
		}
	}
}
