
namespace BaiTapThietKeForm
{
	partial class frmBai4
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSo = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(39, 46);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(289, 251);
			this.listBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(359, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhập số cần tìm";
			// 
			// txtSo
			// 
			this.txtSo.Location = new System.Drawing.Point(463, 57);
			this.txtSo.Name = "txtSo";
			this.txtSo.Size = new System.Drawing.Size(100, 20);
			this.txtSo.TabIndex = 2;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(473, 97);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(75, 23);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm số";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(359, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kết quả";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Location = new System.Drawing.Point(437, 171);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(10, 13);
			this.lblKetQua.TabIndex = 5;
			this.lblKetQua.Text = ".";
			// 
			// frmBai4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtSo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Name = "frmBai4";
			this.Text = "frmBai4";
			this.Load += new System.EventHandler(this.frmBai4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSo;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKetQua;
	}
}