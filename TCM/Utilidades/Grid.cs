using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Grid
	{
		private static void formatarGrid(DataGridView dgv)
		{
			//permite personalizar o grid
			dgv.AutoGenerateColumns = true;
			dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dgv.RowsDefaultCellStyle.BackColor = Color.White;
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
			//ao clicar, seleciona a linha inteira
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dgv.MultiSelect = false;
			// exibe vazio no lugar de null
			dgv.DefaultCellStyle.NullValue = "";
			//Expande a célula automáticamente
			dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgv.ReadOnly = true;
			dgv.RowHeadersVisible = false;
			dgv.AllowUserToAddRows = false;
		}

		public static void atualizarGrid(DataTable dt, DataGridView dgv)
		{
			try
			{
				dgv.DataSource = dt;
				formatarGrid(dgv);
			}
			catch(Exception) { }
		}
	}
}
