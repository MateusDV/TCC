using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	class Limpar
	{
		public static void ClearAllText(Control con)
		{
			foreach (Control c in con.Controls)
			{
				if(c is TextBox)
					((TextBox) c).Clear();
				else if(c is MaskedTextBox)
					((MaskedTextBox) c).Clear();
				else if(c is RadioButton)
					((RadioButton) c).Checked = false;
				else if(c is ComboBox)
					((ComboBox) c).SelectedIndex = -1;
				else if(c is CheckBox)
					((CheckBox) c).Checked = false;
				else
					ClearAllText(c);
			}
		}
	}
}
