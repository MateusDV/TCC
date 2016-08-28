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
	}
}
