﻿namespace CriptoStringMD5
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
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.txtSaida = new System.Windows.Forms.TextBox();
			this.btnCriptografar = new System.Windows.Forms.Button();
			this.btnComparar = new System.Windows.Forms.Button();
			this.labelResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtEntrada
			// 
			this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrada.Location = new System.Drawing.Point(13, 13);
			this.txtEntrada.Multiline = true;
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(663, 116);
			this.txtEntrada.TabIndex = 0;
			// 
			// txtSaida
			// 
			this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaida.Location = new System.Drawing.Point(13, 135);
			this.txtSaida.Multiline = true;
			this.txtSaida.Name = "txtSaida";
			this.txtSaida.Size = new System.Drawing.Size(663, 116);
			this.txtSaida.TabIndex = 1;
			// 
			// btnCriptografar
			// 
			this.btnCriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriptografar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCriptografar.Location = new System.Drawing.Point(13, 267);
			this.btnCriptografar.Name = "btnCriptografar";
			this.btnCriptografar.Size = new System.Drawing.Size(308, 55);
			this.btnCriptografar.TabIndex = 2;
			this.btnCriptografar.Text = "Criptografar";
			this.btnCriptografar.UseVisualStyleBackColor = true;
			this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
			// 
			// btnComparar
			// 
			this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComparar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnComparar.Location = new System.Drawing.Point(368, 267);
			this.btnComparar.Name = "btnComparar";
			this.btnComparar.Size = new System.Drawing.Size(308, 55);
			this.btnComparar.TabIndex = 3;
			this.btnComparar.Text = "Comparar";
			this.btnComparar.UseVisualStyleBackColor = true;
			this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
			// 
			// labelResultado
			// 
			this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResultado.Location = new System.Drawing.Point(13, 335);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(663, 97);
			this.labelResultado.TabIndex = 4;
			this.labelResultado.Text = "Resultado";
			this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 450);
			this.Controls.Add(this.labelResultado);
			this.Controls.Add(this.btnComparar);
			this.Controls.Add(this.btnCriptografar);
			this.Controls.Add(this.txtSaida);
			this.Controls.Add(this.txtEntrada);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.TextBox txtSaida;
		private System.Windows.Forms.Button btnCriptografar;
		private System.Windows.Forms.Button btnComparar;
		private System.Windows.Forms.Label labelResultado;
	}
}

