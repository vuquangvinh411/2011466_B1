﻿
namespace BaiTapThietKeForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.họTênSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai3 = new System.Windows.Forms.ToolStripMenuItem();
			this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênSinhViênToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// họTênSinhViênToolStripMenuItem
			// 
			this.họTênSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBai1,
            this.tsmiBai2,
            this.tsmiBai3,
            this.bài4ToolStripMenuItem});
			this.họTênSinhViênToolStripMenuItem.Name = "họTênSinhViênToolStripMenuItem";
			this.họTênSinhViênToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
			this.họTênSinhViênToolStripMenuItem.Text = "Tiêu Quang Lộc";
			// 
			// tsmiBai1
			// 
			this.tsmiBai1.Image = global::BaiTapThietKeForm.Properties.Resources.icon1;
			this.tsmiBai1.Name = "tsmiBai1";
			this.tsmiBai1.Size = new System.Drawing.Size(180, 22);
			this.tsmiBai1.Text = "Bài 1";
			this.tsmiBai1.Click += new System.EventHandler(this.tsmiBai1_Click);
			// 
			// tsmiBai2
			// 
			this.tsmiBai2.Image = global::BaiTapThietKeForm.Properties.Resources.icon2;
			this.tsmiBai2.Name = "tsmiBai2";
			this.tsmiBai2.Size = new System.Drawing.Size(180, 22);
			this.tsmiBai2.Text = "Bài 2";
			this.tsmiBai2.Click += new System.EventHandler(this.tsmiBai2_Click);
			// 
			// tsmiBai3
			// 
			this.tsmiBai3.Image = global::BaiTapThietKeForm.Properties.Resources.icon3;
			this.tsmiBai3.Name = "tsmiBai3";
			this.tsmiBai3.Size = new System.Drawing.Size(180, 22);
			this.tsmiBai3.Text = "Bài 3";
			this.tsmiBai3.Click += new System.EventHandler(this.tsmiBai3_Click);
			// 
			// bài4ToolStripMenuItem
			// 
			this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
			this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bài4ToolStripMenuItem.Text = "Bài 4";
			this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem họTênSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai1;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai2;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai3;
		private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
	}
}

