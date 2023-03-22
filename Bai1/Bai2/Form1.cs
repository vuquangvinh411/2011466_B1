using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Bạn chọn giới tinh nam", "Thông báo");
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Bạn chọn giới tinh nũ", "Thông báo");
		}

		private void btnToMau_Click(object sender, EventArgs e)
		{
			if (rdDo.Checked)
				txtHopMau.BackColor = Color.Red;
			else
				txtHopMau.BackColor = Color.Green;
		}
	}
}
