using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TCC
{
    class ClasseConexao
    {
        SqlConnection conexao = new SqlConnection();

        private SqlConnection conectar()
        {
            try
            {
                //String strConexao = String.Format("Password=12345; Persist Security Info=True; User ID=sa; Initial Catalog=AALVES; Data Source={0}", Environment.MachineName);

                String user = "aluno";
                String pass = "etesp";
                String banco = "AALVES3";
                String maquina = Environment.MachineName;


				String strConexao = String.Format("User ID={0}; Password={1}; Initial Catalog={2}; Data Source={3}; Persist Security Info=True;", user, pass, banco, maquina);

                //String strConexao = "Password=12345; Persist Security Info=True; User ID=sa; Initial Catalog=AALVES; Data Source="+ Environment.MachineName+"\\SQLExpress";

                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception)
            {
                desconectar();
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                    conexao = null;
                }
            }
            catch (Exception) { }
        }

        public DataSet executarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }

		public int executarSQLNonQuery(String comando_sql)
		{
			try
			{
				conectar();
				SqlCommand cmd = new SqlCommand(comando_sql, conexao);
				return (int) cmd.ExecuteNonQuery();
			}
			catch(Exception) { return 0; }
			finally
			{
				desconectar();
			}
		}
	}
}
