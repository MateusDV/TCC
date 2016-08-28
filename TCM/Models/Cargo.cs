using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Cargo
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Cargo { get; private set; }

		public static String Nome { get; private set; }

		public static Boolean ATIV_CRIAR { get; private set; }

		public static Boolean ATIV_EDIT { get; private set; }

		public static Boolean ATIV_CONS { get; private set; }

		public static Boolean NOTA_ATRIB { get; private set; }

		public static Boolean NOTA_CONS { get; private set; }

		public static Boolean ALUNO_CADS { get; private set; }

		public static Boolean ALUNO_CONS { get; private set; }

		public static Boolean ALUNO_EDIT { get; private set; }

		public static Boolean FUNC_CADS { get; private set; }

		public static Boolean FUNC_CONS { get; private set; }

		public static Boolean FUNC_EDIT { get; private set; }

		public static Boolean PROF_CADS { get; private set; }

		public static Boolean PROF_CONS { get; private set; }

		public static Boolean PROF_EDIT { get; private set; }

		public void select(String id)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			string sql = String.Format("SELECT * FROM CARGO WHERE ID_CARGO = {0}", id);

			ds = conexao.executarSQL(sql);

			ID_Cargo = (int) ds.Tables[0].Rows[0]["ID_Cargo"];
			Nome = ds.Tables[0].Rows[0]["NOME"].ToString();
			ATIV_CRIAR = (Boolean) ds.Tables[0].Rows[0]["ATIV_CRIAR"];
			ATIV_EDIT = (Boolean) ds.Tables[0].Rows[0]["ATIV_EDIT"];
			ATIV_CONS = (Boolean) ds.Tables[0].Rows[0]["ATIV_CONS"];
			NOTA_ATRIB = (Boolean) ds.Tables[0].Rows[0]["NOTA_ATRIB"];
			NOTA_CONS = (Boolean) ds.Tables[0].Rows[0]["NOTA_CONS"];
			ALUNO_CADS = (Boolean) ds.Tables[0].Rows[0]["ALUNO_CADS"];
			ALUNO_CONS = (Boolean) ds.Tables[0].Rows[0]["ALUNO_CONS"];
			ALUNO_EDIT = (Boolean) ds.Tables[0].Rows[0]["ALUNO_EDIT"];
			FUNC_CADS = (Boolean) ds.Tables[0].Rows[0]["FUNC_CADS"];
			FUNC_CONS = (Boolean) ds.Tables[0].Rows[0]["FUNC_CONS"];
			FUNC_EDIT = (Boolean) ds.Tables[0].Rows[0]["FUNC_EDIT"];
			PROF_CADS = (Boolean) ds.Tables[0].Rows[0]["PROF_CADS"];
			PROF_CONS = (Boolean) ds.Tables[0].Rows[0]["PROF_CADS"];
			PROF_EDIT = (Boolean) ds.Tables[0].Rows[0]["PROF_CADS"];
		}

		public int insert(String nome, Boolean v1, Boolean v2, Boolean v3, Boolean v4, Boolean v5, Boolean v6, Boolean v7, Boolean v8, Boolean v9, Boolean v10, Boolean v11, Boolean v12, Boolean v13, Boolean v14)
		{
			conexao = new ClasseConexao();

			String sql = String.Format("INSERT INTO CARGO VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')", nome, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);

			return conexao.executarSQLNonQuery(sql);
		}
	}
}
