﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
	public partial class Mainform : Form
	{
		public Mainform()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			var tenDaNhap = txtTen.Text;

			MessageBox.Show($"Xin chào các bạn {tenDaNhap}. Rất vui được gặp các bạn", "Thông  điệp chào mừng");
		}

		private void btnSaoChep_Click(object sender, EventArgs e)
		{
			txtSaoChep.Text = txtTen.Text;
		}
	}
}
