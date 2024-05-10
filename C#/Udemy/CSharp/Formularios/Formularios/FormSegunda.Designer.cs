namespace Formularios
{
	partial class FormSegunda
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
			this.lblSegunda = new System.Windows.Forms.Label();
			this.btnPrincipal = new System.Windows.Forms.Button();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.btnRetorno = new System.Windows.Forms.Button();
			this.btnFechar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSegunda
			// 
			this.lblSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSegunda.Location = new System.Drawing.Point(13, 13);
			this.lblSegunda.Name = "lblSegunda";
			this.lblSegunda.Size = new System.Drawing.Size(733, 194);
			this.lblSegunda.TabIndex = 0;
			this.lblSegunda.Text = "Segunda Form";
			this.lblSegunda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPrincipal
			// 
			this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrincipal.Location = new System.Drawing.Point(530, 372);
			this.btnPrincipal.Name = "btnPrincipal";
			this.btnPrincipal.Size = new System.Drawing.Size(216, 66);
			this.btnPrincipal.TabIndex = 1;
			this.btnPrincipal.Text = "Principal";
			this.btnPrincipal.UseVisualStyleBackColor = true;
			this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
			// 
			// txtMensagem
			// 
			this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensagem.Location = new System.Drawing.Point(94, 221);
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(570, 38);
			this.txtMensagem.TabIndex = 2;
			// 
			// btnRetorno
			// 
			this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRetorno.Location = new System.Drawing.Point(308, 372);
			this.btnRetorno.Name = "btnRetorno";
			this.btnRetorno.Size = new System.Drawing.Size(216, 66);
			this.btnRetorno.TabIndex = 3;
			this.btnRetorno.Text = "Retorno";
			this.btnRetorno.UseVisualStyleBackColor = true;
			this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
			// 
			// btnFechar
			// 
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(86, 372);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(216, 66);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// FormSegunda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 450);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnRetorno);
			this.Controls.Add(this.txtMensagem);
			this.Controls.Add(this.btnPrincipal);
			this.Controls.Add(this.lblSegunda);
			this.Name = "FormSegunda";
			this.Text = "FormSegunda";
			this.Load += new System.EventHandler(this.FormSegunda_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSegunda;
		private System.Windows.Forms.Button btnPrincipal;
		private System.Windows.Forms.TextBox txtMensagem;
		private System.Windows.Forms.Button btnRetorno;
		private System.Windows.Forms.Button btnFechar;
	}
}