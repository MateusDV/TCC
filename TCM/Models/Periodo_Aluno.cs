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
			ClasseConexao conexao = new ClasseConexao();

			string sql = String.Format("INSERT INTO PERIODO_ALUNO VALUES('{0}', '{1}', DEFAULT)", ID_al, ID_per);

			return conexao.executarSQLNonQuery(sql);
		}

		public static void select(string idAluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string query = string.Format("SELECT * FROM PERIODO_ALUNO WHERE ID_ALUNO = '{0}' ORDER BY YEAR(CADASTRO) DESC, MONTH(CADASTRO) DESC, DAY(CADASTRO) DESC", idAluno);

			ds = conexao.executarSQL(query);
			ID_Aluno = (int) ds.Tables[0].Rows[0][0];
			ID_Periodo = (int) ds.Tables[0].Rows[0][1];
			Cadastro = (DateTime) ds.Tables[0].Rows[0][2];
		}
	}
}
