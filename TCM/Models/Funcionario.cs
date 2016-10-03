using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Funcionario
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Funcionario { get; private set; }

		public static String Nome { get; private set; }

		public static String Sexo { get; private set; }

		public static String RG { get; private set; }

		public static String CPF { get; private set; }

		public static String Rua { get; private set; }

		public static int Num { get; private set; }

		public static String Bairro { get; private set; }

		public static String Cep { get; private set; }

		public static String Cidade { get; private set; }

		public static String Estado { get; private set; }

		public static String Telefone { get; private set; }

		public static String Celular { get; private set; }

		public static String Email { get; private set; }

		public static String Senha { get; private set; }

		public static String Cargo { get; private set; }

		public static DataTable Tabela { get; private set; }

		public bool login(String email, String senha, out String id, out String tipo)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			Compartilha comp = new Compartilha();

			string sql = String.Format("SELECT * FROM FUNCIONARIO WHERE EMAIL = '{0}' AND SENHA = '{1}'", email, senha);

			ds = conexao.executarSQL(sql);

			int conta = ds.Tables[0].Rows.Count;

			if(conta > 0)
			{
				id = ds.Tables[0].Rows[0]["ID_FUNCIONARIO"].ToString();
				tipo = "funcionario";
				comp.Nome = ds.Tables[0].Rows[0]["NOME"].ToString();
				return true;
			}
			else
			{
				id = "";
				tipo = "";
				return false;
			}
		}

		public static int insert(String nome, String sexo, String rg, String cpf, String rua, int numero, String bairro, String cep, String cidade, String estado, String fone, String cel, String email, String senha, int cargo)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			int chec = 0;
			string check = string.Format("SELECT NOME FROM FUNCIONARIO WHERE NOME = '{0}'", nome);
			ds = conexao.executarSQL(check);
			int qnt = 0;
			qnt = ds.Tables[0].Rows.Count;

			if(qnt > 0) //se ja existe
			{
				MessageBox.Show("Esse funcionário já existe nos registros");
			}
			else //se nao existe
			{
				conexao = new ClasseConexao();

				string sql = String.Format("INSERT INTO FUNCIONARIO VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}', {14}, DEFAULT)", nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha, cargo);
				//MessageBox.Show(sql);
				chec = conexao.executarSQLNonQuery(sql);
			}
			return chec;
		}

		public static void select(String id)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = string.Format("SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = {0}", id);

			ds = conexao.executarSQL(sql);

			Tabela = ds.Tables[0];

			ID_Funcionario = (int) ds.Tables[0].Rows[0]["ID_FUNCIONARIO"];
			Nome = ds.Tables[0].Rows[0][1].ToString();
			Sexo = ds.Tables[0].Rows[0][2].ToString();
			RG = ds.Tables[0].Rows[0][3].ToString();
			CPF = ds.Tables[0].Rows[0][4].ToString();
			Rua = ds.Tables[0].Rows[0][5].ToString();
			Num = (int) ds.Tables[0].Rows[0][6];
			Bairro = ds.Tables[0].Rows[0][7].ToString();
			Cep = ds.Tables[0].Rows[0][8].ToString();
			Cidade = ds.Tables[0].Rows[0][9].ToString();
			Estado = ds.Tables[0].Rows[0][10].ToString();
			Telefone = ds.Tables[0].Rows[0][11].ToString();
			Celular = ds.Tables[0].Rows[0][12].ToString();
			Email = ds.Tables[0].Rows[0][13].ToString();
			Senha = ds.Tables[0].Rows[0][14].ToString();
			Cargo = ds.Tables[0].Rows[0]["CARGO"].ToString();
		}

		public static void select(int tipo)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string query;
				if(tipo == 1)
				{
					query = "SELECT ID_FUNCIONARIO AS ID, NOME, SEXO, RG, CPF, CARGO, CADASTRO FROM FUNCIONARIO";
				}
				else if(tipo == 2)
				{
					query = "SELECT ID_FUNCIONARIO AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM FUNCIONARIO";
				}
				else if(tipo == 3)
				{
					query = "SELECT ID_FUNCIONARIO AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM FUNCIONARIO";
				}
				else
				{
					query = "";
					MessageBox.Show("Por favor selecione um modo de exibição");
				}

				ds = conexao.executarSQL(query);
				Tabela = ds.Tables[0];
			}
			catch(Exception) { }
		}

		public static void select(int tipo, string campo, string valor)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				String query;

				if(tipo == 1)
				{
					query = String.Format("SELECT ID_FUNCIONARIO AS ID, NOME, SEXO, RG, CPF, CARGO, CADASTRO FROM FUNCIONARIO WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if(tipo == 2)
				{
					query = String.Format("SELECT ID_FUNCIONARIO AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM FUNCIONARIO WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if(tipo == 3)
				{
					query = String.Format("SELECT ID_FUNCIONARIO AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM FUNCIONARIO WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else
				{
					query = "";
					MessageBox.Show("Por favor selecione um modo de exibição");
				}

				ds = conexao.executarSQL(query);
				Tabela = ds.Tables[0];
			}
			catch(Exception) { }
		}
	}
}
