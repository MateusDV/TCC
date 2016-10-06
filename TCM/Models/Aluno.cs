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

		public static String Rua {	get; private set; }

		public static int Num { get; private set; }

		public static String Cep { get; private set; }

		public static String Cidade { get; private set; }

		public static String Estado { get; private set; }

		public static String Telefone { get; private set; }
		
		public static DataTable Tabela { get; private set; }

		public static int insert(String nome, String email, String sexo, String senha, String rua, int numero, String cep, String cidade, String estado, String telefone)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();
				string nomeProc = "USP_ALUNO_INSERIR";
				string[] campos = { "NOME", "EMAIL", "SEXO", "SENHA", "RUA", "NUM", "CEP", "CIDADE", "ESTADO", "TELEFONE" };
				string[] valores = { nome, email, sexo, senha, rua, numero.ToString(), cep, cidade, estado, telefone };

				ds = conexao.executarProcedure(nomeProc, campos, valores);
				return (int) ds.Tables[0].Rows[0][0];
			}
			catch (Exception) { return 0; }
			



			//int chec = 0;
			//try
			//{
			//	ClasseConexao conexao = new ClasseConexao();

			//	string check = string.Format("SELECT NOME FROM ALUNO WHERE NOME = '{0}'", nome);
			//	DataSet ds = conexao.executarSQL(check);
			//	int qnt = 0;
			//	qnt = ds.Tables[0].Rows.Count;

			//	if(qnt > 0) //se ja existe
			//	{
			//		MessageBox.Show("Esse aluno já existe nos registros");
			//	}
			//	else //se nao existe
			//	{
			//		//MessageBox.Show(curso + "\n" + periodo);

			//		conexao = new ClasseConexao();
			//		ds = new DataSet();

			//		string sql = string.Format("INSERT INTO ALUNO OUTPUT inserted.ID_ALUNO VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}', DEFAULT)", nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone);
			//		//MessageBox.Show(sql);
			//		ds = conexao.executarSQL(sql);
			//		chec = (int) ds.Tables[0].Rows[0]["ID_ALUNO"];
			//	}
			//}
			//catch(Exception) { chec = 0; }
			//return chec;
		}

		public static int update(String id, String nome, String email, String sexo, String senha, String rua, int numero, String cep, String cidade, String estado, String telefone)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				int ret = 0;
				string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = {0}", id);
				string query = string.Format(@"UPDATE ALUNO
SET
NOME = '{0}',
EMAIL = '{1}',
SEXO = '{2}',
SENHA = '{3}',
RUA = '{4}',
NUM = '{5}',
CEP = '{6}',
CIDADE = '{7}',
ESTADO = '{8}',
TELEFONE = '{9}'
WHERE ID_ALUNO = '{10}'", nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone, id);

				ds = conexao.executarSQL(check);

				int qnt = ds.Tables[0].Rows.Count;

				if(qnt > 0)
				{
					var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
					if(confirm.Equals(DialogResult.Yes))
					{
						conexao = new ClasseConexao();

						//MessageBox.Show(query);
						ret = conexao.executarSQLNonQuery(query);
					}
				}
				else
				{
					MessageBox.Show("Esse registro não existe!");
					
				}
				return ret;
			}
			catch(Exception) { return 0; }
		}

		public static int delete(int idAluno)
		{
			int f = 0;
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = '{0}'", idAluno);
				string query = string.Format("DELETE FROM CURSO_ALUNO WHERE CURSO_ALUNO.ID_ALUNO = '{0}'; DELETE FROM PERIODO_ALUNO WHERE PERIODO_ALUNO.ID_ALUNO = '{0}'; DELETE FROM ALUNO WHERE ALUNO.ID_ALUNO = '{0}'", idAluno);
				ds = conexao.executarSQL(check);
				int qnt = 0;
				qnt = ds.Tables[0].Rows.Count;

				if (qnt > 0) //se ja existe
				{
					var confirm = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
					if (confirm.Equals(DialogResult.Yes))
					{
						conexao = new ClasseConexao();

						//MessageBox.Show(query);
						f = conexao.executarSQLNonQuery(query);
					}
				}
				else //se nao existe
				{
					MessageBox.Show("Esse registro não existe!");
				}
			}
			catch (Exception) { }
			return f;
		}

		public static void select(string id)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string query = String.Format("select * from aluno where id_aluno = '{0}'", id);

				ds = conexao.executarSQL(query);

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
		public static void select(int tipo)
		{
			try
			{
				ClasseConexao conexao = new ClasseConexao();
				DataSet ds = new DataSet();

				string query;
				if(tipo == 1)
				{
					query = @"SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
INNER JOIN CURSO_ALUNO ON
ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
INNER JOIN CURSO ON
CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
INNER JOIN PERIODO_ALUNO ON
ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
INNER JOIN PERIODO ON
PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO";
				}
				else if(tipo == 2)
				{
					query = "SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO";
				}
				else if(tipo == 3)
				{
					query = "SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO";
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
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();
			String query;

			if(tipo == 1)
			{
				if(campo.Equals("CURSO"))
				{
					query = String.Format(@"SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
INNER JOIN CURSO_ALUNO ON
ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
INNER JOIN CURSO ON
CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
INNER JOIN PERIODO_ALUNO ON
ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
INNER JOIN PERIODO ON
PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO WHERE CURSO.NOME LIKE '{0}%'", valor);
				}
				else if(campo.Equals("PERIODO"))
				{
					query = String.Format(@"SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
INNER JOIN CURSO_ALUNO ON
ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
INNER JOIN CURSO ON
CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
INNER JOIN PERIODO_ALUNO ON
ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
INNER JOIN PERIODO ON
PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO WHERE PERIODO.NOME LIKE '{0}%'", valor);
				}
				else
				{
					query = String.Format(@"SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
INNER JOIN CURSO_ALUNO ON
ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
INNER JOIN CURSO ON
CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
INNER JOIN PERIODO_ALUNO ON
ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
INNER JOIN PERIODO ON
PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO WHERE ALUNO.{0} LIKE '%{1}%'", campo, valor);
				}
				//MessageBox.Show(query);
			}
			else if(tipo == 2)
			{
				query = String.Format("SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO WHERE {0} LIKE '{1}%'", campo, valor);
				//MessageBox.Show(query);
			}
			else if(tipo == 3)
			{
				query = String.Format("SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO WHERE {0} LIKE '{1}%'", campo, valor);
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
	}
}
