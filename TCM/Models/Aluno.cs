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
			ClasseConexao conexao = new ClasseConexao();

			int chec = 0;

			string check = string.Format("SELECT NOME FROM ALUNO WHERE NOME = '{0}'", nome);
			DataSet ds = conexao.executarSQL(check);
			int qnt = 0;
			qnt = ds.Tables[0].Rows.Count;

			if(qnt > 0) //se ja existe
			{
				MessageBox.Show("Esse aluno já existe nos registros");
			}
			else //se nao existe
			{
				//MessageBox.Show(curso + "\n" + periodo);

				conexao = new ClasseConexao();
				ds = new DataSet();

				string sql = string.Format("INSERT INTO ALUNO OUTPUT inserted.ID_ALUNO VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}', DEFAULT)", nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone);
				//MessageBox.Show(sql);
				ds = conexao.executarSQL(sql);
				chec = (int) ds.Tables[0].Rows[0]["ID_ALUNO"];
			};
			return chec;
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
	}
}
