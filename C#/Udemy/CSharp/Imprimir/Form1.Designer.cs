namespace Imprimir
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.btnVisualizar = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnProximo = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.btnVisualizarPadrao = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.SuspendLayout();
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(481, 387);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(187, 51);
			this.btnImprimir.TabIndex = 0;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.Location = new System.Drawing.Point(13, 13);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(462, 425);
			this.printPreviewControl1.TabIndex = 1;
			// 
			// btnVisualizar
			// 
			this.btnVisualizar.Location = new System.Drawing.Point(481, 13);
			this.btnVisualizar.Name = "btnVisualizar";
			this.btnVisualizar.Size = new System.Drawing.Size(187, 51);
			this.btnVisualizar.TabIndex = 2;
			this.btnVisualizar.Text = "Visualizar";
			this.btnVisualizar.UseVisualStyleBackColor = true;
			this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.Location = new System.Drawing.Point(481, 70);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(85, 51);
			this.btnAnterior.TabIndex = 3;
			this.btnAnterior.Text = "Anterior";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnProximo
			// 
			this.btnProximo.Location = new System.Drawing.Point(583, 70);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(85, 51);
			this.btnProximo.TabIndex = 4;
			this.btnProximo.Text = "Proximo";
			this.btnProximo.UseVisualStyleBackColor = true;
			this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// btnVisualizarPadrao
			// 
			this.btnVisualizarPadrao.Location = new System.Drawing.Point(481, 330);
			this.btnVisualizarPadrao.Name = "btnVisualizarPadrao";
			this.btnVisualizarPadrao.Size = new System.Drawing.Size(187, 51);
			this.btnVisualizarPadrao.TabIndex = 5;
			this.btnVisualizarPadrao.Text = "Visualizar Padrão";
			this.btnVisualizarPadrao.UseVisualStyleBackColor = true;
			this.btnVisualizarPadrao.Click += new System.EventHandler(this.btnVisualizarPadrao_Click);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 450);
			this.Controls.Add(this.btnVisualizarPadrao);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.btnAnterior);
			this.Controls.Add(this.btnVisualizar);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.btnImprimir);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private System.Windows.Forms.Button btnVisualizar;
		private System.Windows.Forms.Button btnProximo;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btnVisualizarPadrao;
		private System.Windows.Forms.PrintDialog printDialog1;
	}
}

