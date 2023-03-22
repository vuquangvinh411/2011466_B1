
namespace BaiTapThietKeForm
{
	partial class frmBai2
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnChonHang = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBoHang = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.lable3 = new System.Windows.Forms.Label();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnChonHang);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(48, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(351, 346);
			this.panel1.TabIndex = 0;
			// 
			// btnChonHang
			// 
			this.btnChonHang.Location = new System.Drawing.Point(237, 142);
			this.btnChonHang.Name = "btnChonHang";
			this.btnChonHang.Size = new System.Drawing.Size(87, 23);
			this.btnChonHang.TabIndex = 2;
			this.btnChonHang.Text = "Chọn hàng";
			this.btnChonHang.UseVisualStyleBackColor = true;
			this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in ",
            "USB Kingmax"});
			this.listBox1.Location = new System.Drawing.Point(35, 61);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(195, 186);
			this.listBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Danh sách hàng hóa";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblSoTien);
			this.panel2.Controls.Add(this.lable3);
			this.panel2.Controls.Add(this.btnTinhTien);
			this.panel2.Controls.Add(this.btnBoHang);
			this.panel2.Controls.Add(this.listBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(418, 33);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(355, 346);
			this.panel2.TabIndex = 3;
			// 
			// btnBoHang
			// 
			this.btnBoHang.Location = new System.Drawing.Point(18, 142);
			this.btnBoHang.Name = "btnBoHang";
			this.btnBoHang.Size = new System.Drawing.Size(87, 23);
			this.btnBoHang.TabIndex = 2;
			this.btnBoHang.Text = "Bỏ hàng";
			this.btnBoHang.UseVisualStyleBackColor = true;
			this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(128, 61);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(195, 186);
			this.listBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "khách đã mua";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(182, 254);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
			this.btnTinhTien.TabIndex = 3;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// lable3
			// 
			this.lable3.AutoSize = true;
			this.lable3.Location = new System.Drawing.Point(18, 305);
			this.lable3.Name = "lable3";
			this.lable3.Size = new System.Drawing.Size(106, 13);
			this.lable3.TabIndex = 4;
			this.lable3.Text = "Tổng tiền thanh toán";
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Location = new System.Drawing.Point(130, 305);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(10, 13);
			this.lblSoTien.TabIndex = 5;
			this.lblSoTien.Text = ".";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmBai2";
			this.Text = "Bán hàng";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnChonHang;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBoHang;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSoTien;
		private System.Windows.Forms.Label lable3;
		private System.Windows.Forms.Button btnTinhTien;
	}
}