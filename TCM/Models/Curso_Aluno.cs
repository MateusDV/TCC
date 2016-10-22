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
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string sql = "USP_CURSO_ALUNO_INSERIR";
				string[] campos = { "ID_ALUNO", "ID_CURSO" };
				string[] valores = { ID_al.ToString(), ID_cur.ToString() };

				ds = conexao.executarProcedure(sql, campos, valores);
				return (int)ds.Tables[0].Rows[0][0];
			}
			catch (Exception) { return 0; }
		}

		public static void select(string idAluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string query = string.Format("SELECT * FROM CURSO_ALUNO WHERE ID_ALUNO = '{0}' AND ATIVO = 1", idAluno);

			ds = conexao.executarSQL(query);
			ID_Aluno = (int) ds.Tables[0].Rows[0][0];
			ID_Curso = (int) ds.Tables[0].Rows[0][1];
			Cadastro = (DateTime) ds.Tables[0].Rows[0][2];
			tabela = ds.Tables[0];
		}
	}
}
