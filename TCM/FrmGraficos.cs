using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TCC
{
	public partial class FrmGraficos : Form
	{
		public FrmGraficos()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			ds = conexao.executarSQL("Exec USP_PRODUTOS_VENDAS_REPORT");
			chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
			chart1.Series["Series1"].ChartType = SeriesChartType.Column;
			chart1.Palette = ChartColorPalette.SeaGreen;
			//chart1.Titles.Add("Vendas do ano");
			chart1.DataSource = ds.Tables[0].DefaultView;
			chart1.Series[0].XValueMember = "nome_prod";
			chart1.Series[0].YValueMembers = "quantidade";
		}

		private void FrmGraficos_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Vendas");
		}
	}
}
