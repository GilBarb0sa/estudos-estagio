﻿namespace LINQ1
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
			this.lista = new System.Windows.Forms.ListBox();
			this.txtConsulta = new System.Windows.Forms.TextBox();
			this.btnExecutar = new System.Windows.Forms.Button();
			this.btnWhere = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista
			// 
			this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lista.FormattingEnabled = true;
			this.lista.ItemHeight = 29;
			this.lista.Location = new System.Drawing.Point(13, 13);
			this.lista.Name = "lista";
			this.lista.Size = new System.Drawing.Size(517, 410);
			this.lista.TabIndex = 0;
			// 
			// txtConsulta
			// 
			this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConsulta.Location = new System.Drawing.Point(536, 13);
			this.txtConsulta.Name = "txtConsulta";
			this.txtConsulta.Size = new System.Drawing.Size(141, 31);
			this.txtConsulta.TabIndex = 1;
			// 
			// btnExecutar
			// 
			this.btnExecutar.Location = new System.Drawing.Point(536, 50);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(141, 31);
			this.btnExecutar.TabIndex = 2;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = true;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// btnWhere
			// 
			this.btnWhere.Location = new System.Drawing.Point(536, 87);
			this.btnWhere.Name = "btnWhere";
			this.btnWhere.Size = new System.Drawing.Size(141, 31);
			this.btnWhere.TabIndex = 3;
			this.btnWhere.Text = "Where";
			this.btnWhere.UseVisualStyleBackColor = true;
			this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 450);
			this.Controls.Add(this.btnWhere);
			this.Controls.Add(this.btnExecutar);
			this.Controls.Add(this.txtConsulta);
			this.Controls.Add(this.lista);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lista;
		private System.Windows.Forms.TextBox txtConsulta;
		private System.Windows.Forms.Button btnExecutar;
		private System.Windows.Forms.Button btnWhere;
	}
}
