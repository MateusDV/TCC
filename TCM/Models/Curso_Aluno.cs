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

		public static int insert(int ID_al, int ID_cur)
		{
			ClasseConexao conexao = new ClasseConexao();

			string sql = String.Format("INSERT INTO CURSO_ALUNO VALUES('{0}', '{1}')", ID_al, ID_cur);

			return conexao.executarSQLNonQuery(sql);
		}

		public static void select(string idAluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string query = string.Format("SELECT * FROM CURSO_ALUNO WHERE ID_ALUNO = '{0}'", idAluno);

			ds = conexao.executarSQL(query);
			ID_Aluno = (int) ds.Tables[0].Rows[0][0];
			ID_Curso = (int) ds.Tables[0].Rows[0][1];
		}

		public static int update(int idCurso, int idAluno)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();

				string query = string.Format("UPDATE CURSO_ALUNO SET ID_CURSO = '{0}' WHERE ID_ALUNO = '{1}'", idCurso, idAluno);

				return conexao.executarSQLNonQuery(query);
			}
			catch (Exception) { return 0; }
		}
	}
}
