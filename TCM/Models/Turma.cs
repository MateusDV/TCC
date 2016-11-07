using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Turma
	{
		public static string freq { get; private set; }

		public static DataTable Nomes { get; private set; }

		public static DataTable Alunos { get; private set; }

		public static DataTable Alunos_Spec { get; private set; }

		public static void selectNome(int id_curso, int id_periodo)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_TURMA_CONSULTAR_NOME";
			string[] param = { "ID_CURSO", "ID_PERIODO" };
			string[] valor = { id_curso.ToString(), id_periodo.ToString() };

			ds = conexao.executarProcedure(sql, param, valor);

			Nomes = ds.Tables[0];
		}

		public static void selectAlunos(string nome_turma)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_TURMA_CONSULTAR_ALUNOS";
			string[] param = { "NOME_TURMA" };
			string[] valor = { nome_turma };

			ds = conexao.executarProcedure(sql, param, valor);

			Alunos = ds.Tables[0];
		}

		public static void selectAlunoEspec(string nome_aluno)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			string sql = "USP_TURMA_CONSULTAR_ALUNO_ESPECIFICO";
			string[] param = { "NOME_ALUNO" };
			string[] valor = { nome_aluno };

			ds = conexao.executarProcedure(sql, param, valor);

			Alunos_Spec = ds.Tables[0];

			int total = (int) Alunos_Spec.Rows[0][2];
			int faltas = (int) Alunos_Spec.Rows[0][3];

			freq = Validar.porcentagem_faltas(total, faltas).ToString();
		}
	}
}
