using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TCC
{
	public partial class FrmRelatorios : Form
	{
		public FrmRelatorios()
		{
			InitializeComponent();
		}

		private void FrmRelatorios_Load(object sender, EventArgs e)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			ds = conexao.executarSQL("EXEC USP_PRODUTOS_VENDAS_REPORT");
			ReportDataSource datasourse = new ReportDataSource("DataSet1", ds.Tables[0].DefaultView);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(datasourse);
			this.reportViewer1.RefreshReport();
		}
	}
}
