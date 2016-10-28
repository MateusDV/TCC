using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Aluno
	{
		public static int ID_Aluno { get; private set; }

		public static String Nome { get; private set; }

		public static String Email { get; private set; }

		public static String Sexo { get; private set; }

		public static String Senha { get; private set; }

		public static String Rua { get; private set; }

		public static int Num { get; private set; }

		public static String Cep { get; private set; }

		public static String Cidade { get; private set; }

		public static String Estado { get; private set; }

		public static String Telefone { get; private set; }

		public static bool Ativo { get; private set; }
		
		public static DataTable Tabela { get; set; }

		public static int insert(String nome, String email, String sexo, String senha, String rua, int numero, String cep, String cidade, String estado, String telefone)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				string nomeProc = "USP_ALUNO_INSERIR";
				string[] campos = { "NOME", "EMAIL", "SEXO", "SENHA", "RUA", "NUM", "CEP", "CIDADE", "ESTADO", "TELEFONE", "ATIVO" };
				string[] valores = { nome, email, sexo, senha, rua, numero.ToString(), cep, cidade, estado, telefone , "1"};

				ds = conexao.executarProcedure(nomeProc, campos, valores);
				return (int) ds.Tables[0].Rows[0][0];
			}
			catch (Exception) { return 0; }
		}

		public static int update(String id, String nome, String email, String sexo, String senha, String rua, int numero, String cep, String cidade, String estado, String telefone)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				string nomeProc = "USP_ALUNO_ALTERAR";
				string[] campos = { "ID_ALUNO", "NOME", "EMAIL", "SEXO", "SENHA", "RUA", "NUM", "CEP", "CIDADE", "ESTADO", "TELEFONE" };
				string[] valores = { id, nome, email, sexo, senha, rua, numero.ToString(), cep, cidade, estado, telefone };

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

		public static int delete(string idAluno)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				string nomeProc = "USP_ALUNO_DESATIVAR";
				string[] campos = { "ID_ALUNO" };
				string[] valores = { idAluno };

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

		public static void select(string id)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string nomeProc = "USP_ALUNO_CONSULTAR_ID";
				string[] campos = { "ID" };
				string[] valor = { id };

				ds = conexao.executarProcedure(nomeProc, campos, valor);

				Tabela = ds.Tables[0];

				ID_Aluno = (int) Tabela.Rows[0][0];
				Nome = Tabela.Rows[0][1].ToString();
				Email = Tabela.Rows[0][2].ToString();
				Sexo = Tabela.Rows[0][3].ToString();
				Senha = Tabela.Rows[0][4].ToString();
				Rua = Tabela.Rows[0][5].ToString();
				Num = (int) Tabela.Rows[0][6];
				Cep = Tabela.Rows[0][7].ToString();
				Cidade = Tabela.Rows[0][8].ToString();
				Estado = Tabela.Rows[0][9].ToString();
				Telefone = Tabela.Rows[0][10].ToString();
			}
			catch(Exception) { }
		}
		public static void select(int tipo, int ativo)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string nomeProc = "USP_ALUNO_CONSULTAR_TIPO";
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
				String query = "USP_ALUNO_CONSULTAR_ESPECIFICO";
				string[] param = { "TIPO", "ATIVO", "CAMPO", "VALOR" };
				string[] val = { tipo.ToString(), ativo.ToString(), campo, valor };

				ds = conexao.executarProcedure(query, param, val);

				if(ds != null)
				{
					Tabela = ds.Tables[0];
				}
				else
				{
					MessageBox.Show("Por favor selecione um modo de exibição");
				}
			}
			catch(Exception) { }
		}
	}
}
