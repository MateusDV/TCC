using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{ 
	public class Curso_Aluno
	{
		public static int ID_Aluno { get; private set; }

		public static int ID_Curso { get; private set; }

		public static DateTime Cadastro { get; private set; }

		public static DataTable tabela { get; private set; }

		public static int insert(int ID_al, int ID_cur)
		{
			ClasseConexao conexao = new ClasseConexao();

			string sql = String.Format("INSERT INTO CURSO_ALUNO VALUES('{0}', '{1}', DEFAULT)", ID_al, ID_cur);

			return conexao.executarSQLNonQuery(sql);
		}

		public static void select(string idAluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string query = string.Format("SELECT * FROM CURSO_ALUNO WHERE ID_ALUNO = '{0}' ORDER BY YEAR(CADASTRO) DESC, MONTH(CADASTRO) DESC, DAY(CADASTRO) DESC", idAluno);

			ds = conexao.executarSQL(query);
			ID_Aluno = (int) ds.Tables[0].Rows[0][0];
			ID_Curso = (int) ds.Tables[0].Rows[0][1];
			Cadastro = (DateTime) ds.Tables[0].Rows[0][2];
			tabela = ds.Tables[0];
		}
	}
}
