﻿
namespace BaiTapThietKeForm
{
	partial class frmBai3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTuMoi = new System.Windows.Forms.TextBox();
			this.txtNghia = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txtHienThiNghia = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ mới";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nghĩa của từ";
			// 
			// txtTuMoi
			// 
			this.txtTuMoi.Location = new System.Drawing.Point(150, 48);
			this.txtTuMoi.Name = "txtTuMoi";
			this.txtTuMoi.Size = new System.Drawing.Size(316, 20);
			this.txtTuMoi.TabIndex = 2;
			// 
			// txtNghia
			// 
			this.txtNghia.Location = new System.Drawing.Point(150, 118);
			this.txtNghia.Name = "txtNghia";
			this.txtNghia.Size = new System.Drawing.Size(316, 20);
			this.txtNghia.TabIndex = 3;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(252, 159);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm từ mới";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Danh sách từ mới";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(348, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nghĩa của từ";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(45, 241);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(188, 160);
			this.listBox1.TabIndex = 7;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// txtHienThiNghia
			// 
			this.txtHienThiNghia.FormattingEnabled = true;
			this.txtHienThiNghia.Location = new System.Drawing.Point(278, 241);
			this.txtHienThiNghia.MultiColumn = true;
			this.txtHienThiNghia.Name = "txtHienThiNghia";
			this.txtHienThiNghia.Size = new System.Drawing.Size(188, 160);
			this.txtHienThiNghia.TabIndex = 8;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtHienThiNghia);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtNghia);
			this.Controls.Add(this.txtTuMoi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "frmBai3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTuMoi;
		private System.Windows.Forms.TextBox txtNghia;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox txtHienThiNghia;
	}
}