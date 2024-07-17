namespace Teste1
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
			this.btnExecutar = new System.Windows.Forms.Button();
			this.listaResultado = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnExecutar
			// 
			this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExecutar.Location = new System.Drawing.Point(232, 376);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(217, 49);
			this.btnExecutar.TabIndex = 0;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = true;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// listaResultado
			// 
			this.listaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listaResultado.FormattingEnabled = true;
			this.listaResultado.ItemHeight = 25;
			this.listaResultado.Location = new System.Drawing.Point(13, 13);
			this.listaResultado.Name = "listaResultado";
			this.listaResultado.Size = new System.Drawing.Size(619, 329);
			this.listaResultado.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 450);
			this.Controls.Add(this.listaResultado);
			this.Controls.Add(this.btnExecutar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExecutar;
		private System.Windows.Forms.ListBox listaResultado;
	}
}

