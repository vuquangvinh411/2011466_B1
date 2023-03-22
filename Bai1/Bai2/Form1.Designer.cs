
namespace Bai2
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdXanh = new System.Windows.Forms.RadioButton();
			this.rdDo = new System.Windows.Forms.RadioButton();
			this.btnToMau = new System.Windows.Forms.Button();
			this.txtHopMau = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(149, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(204, 92);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn giới tính";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(7, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Nam";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 61);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(39, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Nữ";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnToMau);
			this.groupBox2.Controls.Add(this.rdXanh);
			this.groupBox2.Controls.Add(this.rdDo);
			this.groupBox2.Location = new System.Drawing.Point(149, 181);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(204, 92);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chọn màu";
			// 
			// rdXanh
			// 
			this.rdXanh.AutoSize = true;
			this.rdXanh.Location = new System.Drawing.Point(7, 61);
			this.rdXanh.Name = "rdXanh";
			this.rdXanh.Size = new System.Drawing.Size(72, 17);
			this.rdXanh.TabIndex = 1;
			this.rdXanh.Text = "Màu xanh";
			this.rdXanh.UseVisualStyleBackColor = true;
			// 
			// rdDo
			// 
			this.rdDo.AutoSize = true;
			this.rdDo.Checked = true;
			this.rdDo.Location = new System.Drawing.Point(7, 20);
			this.rdDo.Name = "rdDo";
			this.rdDo.Size = new System.Drawing.Size(62, 17);
			this.rdDo.TabIndex = 0;
			this.rdDo.TabStop = true;
			this.rdDo.Text = "Màu đỏ";
			this.rdDo.UseVisualStyleBackColor = true;
			// 
			// btnToMau
			// 
			this.btnToMau.Location = new System.Drawing.Point(96, 37);
			this.btnToMau.Name = "btnToMau";
			this.btnToMau.Size = new System.Drawing.Size(75, 23);
			this.btnToMau.TabIndex = 2;
			this.btnToMau.Text = "Tô màu";
			this.btnToMau.UseVisualStyleBackColor = true;
			this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
			// 
			// txtHopMau
			// 
			this.txtHopMau.Location = new System.Drawing.Point(387, 195);
			this.txtHopMau.Multiline = true;
			this.txtHopMau.Name = "txtHopMau";
			this.txtHopMau.ReadOnly = true;
			this.txtHopMau.Size = new System.Drawing.Size(177, 77);
			this.txtHopMau.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtHopMau);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "MainForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnToMau;
		private System.Windows.Forms.RadioButton rdXanh;
		private System.Windows.Forms.RadioButton rdDo;
		private System.Windows.Forms.TextBox txtHopMau;
	}
}

