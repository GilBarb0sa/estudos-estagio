namespace LINQ1
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
			this.btnOrderBy = new System.Windows.Forms.Button();
			this.btnGroupBy = new System.Windows.Forms.Button();
			this.btnAgregacao = new System.Windows.Forms.Button();
			this.btnOperadoresDeElementos = new System.Windows.Forms.Button();
			this.btnLinqLambda = new System.Windows.Forms.Button();
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
			// btnOrderBy
			// 
			this.btnOrderBy.Location = new System.Drawing.Point(536, 124);
			this.btnOrderBy.Name = "btnOrderBy";
			this.btnOrderBy.Size = new System.Drawing.Size(141, 31);
			this.btnOrderBy.TabIndex = 4;
			this.btnOrderBy.Text = "Order By";
			this.btnOrderBy.UseVisualStyleBackColor = true;
			this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
			// 
			// btnGroupBy
			// 
			this.btnGroupBy.Location = new System.Drawing.Point(536, 161);
			this.btnGroupBy.Name = "btnGroupBy";
			this.btnGroupBy.Size = new System.Drawing.Size(141, 31);
			this.btnGroupBy.TabIndex = 5;
			this.btnGroupBy.Text = "Group By";
			this.btnGroupBy.UseVisualStyleBackColor = true;
			this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
			// 
			// btnAgregacao
			// 
			this.btnAgregacao.Location = new System.Drawing.Point(536, 198);
			this.btnAgregacao.Name = "btnAgregacao";
			this.btnAgregacao.Size = new System.Drawing.Size(141, 31);
			this.btnAgregacao.TabIndex = 6;
			this.btnAgregacao.Text = "Operadores de Agregação";
			this.btnAgregacao.UseVisualStyleBackColor = true;
			this.btnAgregacao.Click += new System.EventHandler(this.btnAgregacao_Click);
			// 
			// btnOperadoresDeElementos
			// 
			this.btnOperadoresDeElementos.Location = new System.Drawing.Point(536, 235);
			this.btnOperadoresDeElementos.Name = "btnOperadoresDeElementos";
			this.btnOperadoresDeElementos.Size = new System.Drawing.Size(141, 31);
			this.btnOperadoresDeElementos.TabIndex = 7;
			this.btnOperadoresDeElementos.Text = "Operadores de Elementos";
			this.btnOperadoresDeElementos.UseVisualStyleBackColor = true;
			this.btnOperadoresDeElementos.Click += new System.EventHandler(this.btnOperadoresDeElementos_Click);
			// 
			// btnLinqLambda
			// 
			this.btnLinqLambda.Location = new System.Drawing.Point(536, 272);
			this.btnLinqLambda.Name = "btnLinqLambda";
			this.btnLinqLambda.Size = new System.Drawing.Size(141, 31);
			this.btnLinqLambda.TabIndex = 8;
			this.btnLinqLambda.Text = "Linq Lambda";
			this.btnLinqLambda.UseVisualStyleBackColor = true;
			this.btnLinqLambda.Click += new System.EventHandler(this.btnLinqLambda_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 450);
			this.Controls.Add(this.btnLinqLambda);
			this.Controls.Add(this.btnOperadoresDeElementos);
			this.Controls.Add(this.btnAgregacao);
			this.Controls.Add(this.btnGroupBy);
			this.Controls.Add(this.btnOrderBy);
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
		private System.Windows.Forms.Button btnOrderBy;
		private System.Windows.Forms.Button btnGroupBy;
		private System.Windows.Forms.Button btnAgregacao;
		private System.Windows.Forms.Button btnOperadoresDeElementos;
		private System.Windows.Forms.Button btnLinqLambda;
	}
}

