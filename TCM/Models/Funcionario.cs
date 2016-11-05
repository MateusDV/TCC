using System;
using System.Data;
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

		public static bool Ativo { get; private set; }

		public static DataTable Tabela { get; set; }

		public bool login(String email, String senha)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			Compartilha comp = new Compartilha();

			string sql = String.Format("USP_PROG_LOGIN");
            string[] param = { "EMAIL", "SENHA" };
            string[] valores = { email, senha };

			ds = conexao.executarProcedure(sql, param, valores);

			int conta = ds.Tables[0].Rows.Count;

			if((int) ds.Tables[0].Rows[0][0] !=0 )
			{
                comp.Id = ds.Tables[0].Rows[0][0].ToString();
                comp.Nome = ds.Tables[0].Rows[0][1].ToString();
                comp.Cargo = ds.Tables[0].Rows[0][2].ToString();
				return true;
			}
			else
			{
				return false;
			}
		}

		public static int alterar_senha(int id, string cargo, string atual, string nova)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_FUNC_PROF_ALT_SENHA";
			string[] campos = { "ID", "CARGO", "SENHA_ATUAL", "SENHA_NOVA" };
			string[] valores = { id.ToString(), cargo, atual, nova };

			ds = conexao.executarProcedure(sql, campos, valores);
			return (int) ds.Tables[0].Rows[0][0];
 		}

		public static int insert(String nome, String sexo, String rg, String cpf, String rua, int numero, String bairro, String cep, String cidade, String estado, String fone, String cel, String email, String senha, int cargo)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string nomeProc = "USP_FUNC_INSERIR";
				string[] campos = { "NOME", "SEXO", "RG", "CPF", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL", "SENHA", "CARGO", "ATIVO" };
				string[] valores = { nome, sexo, rg, cpf, rua, numero.ToString(), bairro, cep, cidade, estado, fone, cel, email, senha, cargo.ToString(), "1" };

				ds = conexao.executarProcedure(nomeProc, campos, valores);
				return (int) ds.Tables[0].Rows[0][0];
			}
			catch(Exception) { return 0; }
		}

		public static int update(int id, String nome, String sexo, String rg, String cpf, String rua, int numero, String bairro, String cep, String cidade, String estado, String fone, String cel, String email, String senha, int cargo)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				string nomeProc = "USP_FUNC_ALTERAR";
				string[] campos = { "ID_FUNCIONARIO", "NOME", "SEXO", "RG", "CPF", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL", "SENHA", "CARGO", "ATIVO" };
				string[] valores = { id.ToString(), nome, sexo, rg, cpf, rua, numero.ToString(), bairro, cep, cidade, estado, fone, cel, email, senha, cargo.ToString(), "1" };

				var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
				if (confirm.Equals(DialogResult.Yes))
				{
					ds = conexao.executarProcedure(nomeProc, campos, valores);
					return (int)ds.Tables[0].Rows[0][0];
				}
				else
				{
					return 0;
				}
			}
			catch (Exception) { return 0; }
		}

		public static int delete(string idFuncionario)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				string nomeProc = "USP_FUNC_DESATIVAR";
				string[] campos = { "ID_FUNCIONARIO" };
				string[] valores = { idFuncionario };

				var confirm = MessageBox.Show("Tem certeza que deseja desativar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
				if (confirm.Equals(DialogResult.Yes))
				{
					ds = conexao.executarProcedure(nomeProc, campos, valores);
					return (int)ds.Tables[0].Rows[0][0];
				}
				else
				{
					return 0;
				}
			}
			catch (Exception) { return 0; }
		}

		public static void select(String id)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string nomeProc = "USP_FUNC_CONSULTAR_ID";
			string[] campos = { "ID" };
			string[] valor = { id };

			ds = conexao.executarProcedure(nomeProc, campos, valor);

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

		public static void select(int tipo, int ativo)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string nomeProc = "USP_FUNC_CONSULTAR_TIPO";
				string[] campos = { "TIPO", "ATIVO" };
				string[] valor = { tipo.ToString(), ativo.ToString() };

				ds = conexao.executarProcedure(nomeProc, campos, valor);
				Tabela = ds.Tables[0];
			}
			catch (Exception) { }
		}

		public static void select(int tipo, int ativo, string campo, string valor)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				String query = "USP_FUNC_CONSULTAR_ESPECIFICO";
				string[] param = { "TIPO", "ATIVO", "CAMPO", "VALOR" };
				string[] val = { tipo.ToString(), ativo.ToString(), campo, valor };

				ds = conexao.executarProcedure(query, param, val);

				if (ds != null)
				{
					Tabela = ds.Tables[0];
				}
				else
				{
					MessageBox.Show("Por favor selecione um modo de exibição");
				}
			}
			catch (Exception) { }
		}
	}
}
