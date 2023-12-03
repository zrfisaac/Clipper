using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipper
{
	public partial class MenuMainForm : Form
	{
		bool vClose = false;
		string vClipboardTextLast = "";
		MenuAboutForm vMenuAboutForm = null;

		private void fnClose()
		{
			this.miNotify.Visible = false;
			this.vClose = true;
			Application.Exit();
		}

		public MenuMainForm()
		{
			InitializeComponent();
		}

		private void MenuMainForm_Load(object sender, EventArgs e)
		{
			// aaa
		}

		private void tmTimer_Tick(object sender, EventArgs e)
		{
			string _vClipboardText = "";
			if (Clipboard.ContainsText())
			{
				_vClipboardText = Clipboard.GetText();
				if (_vClipboardText != "" && _vClipboardText != this.vClipboardTextLast)
				{
					this.vClipboardTextLast = _vClipboardText;
					ToolStripMenuItem _vMenuItem = new ToolStripMenuItem("");
					_vMenuItem.Text = _vClipboardText;
					miNotifyMenu.Items.Insert(0, _vMenuItem);

					this.lbList.Items.Insert(0, _vClipboardText);
				}
			}
		}

		private void miCloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.fnClose();
		}

		private void miNotifyMenuClose_Click(object sender, EventArgs e)
		{
			this.fnClose();
		}

		private void MenuMainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//this.fnClose();
		}

		private void MenuMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.vClose)
			{
				e.Cancel = true;
				this.Hide();
			}
		}

		private void miNotify_DoubleClick(object sender, EventArgs e)
		{
			if (this.Visible)
	            this.Hide();
			else
				this.Show();
		}

		private void miAboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (vMenuAboutForm == null)
				vMenuAboutForm = new MenuAboutForm();
			vMenuAboutForm.ShowDialog();
		}
	}
}
