﻿
namespace BaiTapThietKeForm
{
	partial class frmBai1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdXanh = new System.Windows.Forms.RadioButton();
			this.rdDo = new System.Windows.Forms.RadioButton();
			this.rdTrang = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSoTien = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BaiTapThietKeForm.Properties.Resources.buspic;
			this.pictureBox1.Location = new System.Drawing.Point(41, 52);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(279, 184);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTrang);
			this.groupBox1.Controls.Add(this.rdDo);
			this.groupBox1.Controls.Add(this.rdXanh);
			this.groupBox1.Location = new System.Drawing.Point(369, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(214, 184);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn màu xe";
			// 
			// rdXanh
			// 
			this.rdXanh.AutoSize = true;
			this.rdXanh.Location = new System.Drawing.Point(20, 33);
			this.rdXanh.Name = "rdXanh";
			this.rdXanh.Size = new System.Drawing.Size(50, 17);
			this.rdXanh.TabIndex = 0;
			this.rdXanh.TabStop = true;
			this.rdXanh.Text = "Xanh";
			this.rdXanh.UseVisualStyleBackColor = true;
			this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// rdDo
			// 
			this.rdDo.AutoSize = true;
			this.rdDo.Location = new System.Drawing.Point(20, 69);
			this.rdDo.Name = "rdDo";
			this.rdDo.Size = new System.Drawing.Size(39, 17);
			this.rdDo.TabIndex = 1;
			this.rdDo.TabStop = true;
			this.rdDo.Text = "Đỏ";
			this.rdDo.UseVisualStyleBackColor = true;
			this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
			// 
			// rdTrang
			// 
			this.rdTrang.AutoSize = true;
			this.rdTrang.Location = new System.Drawing.Point(20, 109);
			this.rdTrang.Name = "rdTrang";
			this.rdTrang.Size = new System.Drawing.Size(53, 17);
			this.rdTrang.TabIndex = 2;
			this.rdTrang.TabStop = true;
			this.rdTrang.Text = "Trắng";
			this.rdTrang.UseVisualStyleBackColor = true;
			this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(384, 251);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Đơn giá";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(384, 278);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Số lượng";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(435, 251);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(100, 20);
			this.txtDonGia.TabIndex = 4;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(435, 275);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
			this.txtSoLuong.TabIndex = 5;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(435, 301);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
			this.btnTinhTien.TabIndex = 6;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(384, 332);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tổng số tiền thanh toán";
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Location = new System.Drawing.Point(517, 331);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(13, 13);
			this.lblSoTien.TabIndex = 9;
			this.lblSoTien.Text = "0";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmBai1";
			this.Text = "frmBai1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTrang;
		private System.Windows.Forms.RadioButton rdDo;
		private System.Windows.Forms.RadioButton rdXanh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblSoTien;
	}
}