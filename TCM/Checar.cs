using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Checar
	{
		public static bool textbox(Form esse)
		{
			var emptyTextboxes = from tb in esse.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

			var emptyMask = from mb in esse.Controls.OfType<MaskedTextBox>() where string.IsNullOrEmpty(mb.Text) select mb;

			return (emptyTextboxes.Any() || emptyMask.Any()) ? true : false;
		}
	}
}
