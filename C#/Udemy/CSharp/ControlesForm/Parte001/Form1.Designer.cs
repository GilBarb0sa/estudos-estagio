namespace Parte001
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoEllipsis = true;
			this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTitulo.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTitulo.Image = global::Parte001.Properties.Resources.c_sharp;
			this.lblTitulo.Location = new System.Drawing.Point(11, 11);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(2);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(60, 6, 60, 6);
			this.lblTitulo.Size = new System.Drawing.Size(703, 438);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Dev-Saskaroth  / Estudos de Progmação em C#";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
			this.lblTitulo.MouseEnter += new System.EventHandler(this.lblTitulo_MouseEnter);
			this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 450);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
	}
}

