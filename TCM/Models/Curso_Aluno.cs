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
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Aluno { get; private set; }

		public static int ID_Curso { get; private set; }

		public static int insert(int ID_al, int ID_cur)
		{
			ClasseConexao conexao = new ClasseConexao();

			string sql = String.Format("INSERT INTO CURSO_ALUNO VALUES('{0}', '{1}')", ID_al, ID_cur);

			return conexao.executarSQLNonQuery(sql);
		}
	}
}
