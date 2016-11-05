using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Prova
	{
		public static int ID_Prova { get; private set; }

		public static String Nome { get; private set; }

		public static String Descricao { get; private set; }

		public static int ID_Professor { get; private set; }

		public static DataTable Tabela { get; set; }

		public static int insert(string nome, string descricao, string id_prof)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_INSERIR";
			string[] param = { "NOME", "DESCRICAO", "ID_PROFESSOR" };
			string[] valor = { nome, descricao, id_prof };

			ds = conexao.executarProcedure(sql, param, valor);

			return (int)ds.Tables[0].Rows[0][0];
		}

		public static int update(string id, string nome, string descricao)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_ALTERAR";
			string[] param = { "ID", "NOME", "DESCRICAO" };
			string[] valor = { id, nome, descricao };

			ds = conexao.executarProcedure(sql, param, valor);

			return (int) ds.Tables[0].Rows[0][0];
		}
		
		public static int delete(string id)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_EXCLUIR";
			string[] param = { "ID" };
			string[] valor = { id };

			ds = conexao.executarProcedure(sql, param, valor);

			return (int) ds.Tables[0].Rows[0][0];
		}

		public static void select(string id_prova)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_CONSULTAR_ID";
			string[] param = { "ID" };
			string[] valor = { id_prova };

			ds = conexao.executarProcedure(sql, param, valor);

			ID_Prova = (int) ds.Tables[0].Rows[0][0];
			Nome = ds.Tables[0].Rows[0][1].ToString();
			Descricao = ds.Tables[0].Rows[0][2].ToString();
			ID_Professor = (int) ds.Tables[0].Rows[0][3];

			Tabela = ds.Tables[0];
		}

		public static void select(int id_professor)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_CONSULTAR_TODOS";
			string[] param = { "ID_PROFESSOR" };
			string[] valor = { id_professor.ToString() };

			ds = conexao.executarProcedure(sql, param, valor);

			Tabela = ds.Tables[0];
		}

		public static void select(string campo, string valor)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_PROVA_CONSULTAR_ESPECIFICO";
			string[] param = { "CAMPO", "VALOR" };
			string[] valores = { campo, valor };

			ds = conexao.executarProcedure(sql, param, valores);

			Tabela = ds.Tables[0];
		}
	}
}
