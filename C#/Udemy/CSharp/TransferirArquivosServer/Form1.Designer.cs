namespace TransferirArquivosServer
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
			this.listaLogs = new System.Windows.Forms.ListBox();
			this.btnEstabelecerConexao = new System.Windows.Forms.Button();
			this.btnPararServidor = new System.Windows.Forms.Button();
			this.txtPasta = new System.Windows.Forms.LinkLabel();
			this.titulo = new System.Windows.Forms.Label();
			this.txtEnderecoIP = new System.Windows.Forms.TextBox();
			this.txtPorta = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
			this.SuspendLayout();
			// 
			// listaLogs
			// 
			this.listaLogs.FormattingEnabled = true;
			this.listaLogs.Location = new System.Drawing.Point(12, 232);
			this.listaLogs.Name = "listaLogs";
			this.listaLogs.Size = new System.Drawing.Size(667, 199);
			this.listaLogs.TabIndex = 0;
			this.listaLogs.TabStop = false;
			// 
			// btnEstabelecerConexao
			// 
			this.btnEstabelecerConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEstabelecerConexao.Location = new System.Drawing.Point(12, 112);
			this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
			this.btnEstabelecerConexao.Size = new System.Drawing.Size(289, 49);
			this.btnEstabelecerConexao.TabIndex = 1;
			this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
			this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
			this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
			// 
			// btnPararServidor
			// 
			this.btnPararServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPararServidor.Location = new System.Drawing.Point(390, 112);
			this.btnPararServidor.Name = "btnPararServidor";
			this.btnPararServidor.Size = new System.Drawing.Size(289, 49);
			this.btnPararServidor.TabIndex = 2;
			this.btnPararServidor.TabStop = false;
			this.btnPararServidor.Text = "Parar Servidor";
			this.btnPararServidor.UseVisualStyleBackColor = true;
			this.btnPararServidor.Click += new System.EventHandler(this.btnPararServidor_Click);
			// 
			// txtPasta
			// 
			this.txtPasta.AutoSize = true;
			this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasta.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.txtPasta.Location = new System.Drawing.Point(12, 186);
			this.txtPasta.Name = "txtPasta";
			this.txtPasta.Size = new System.Drawing.Size(322, 25);
			this.txtPasta.TabIndex = 3;
			this.txtPasta.TabStop = true;
			this.txtPasta.Text = "Clique para selecionar a pasta...";
			this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
			// 
			// titulo
			// 
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(15, 9);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(664, 62);
			this.titulo.TabIndex = 4;
			this.titulo.Text = "Servidor para Compartilhar Arquivo";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtEnderecoIP
			// 
			this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnderecoIP.Location = new System.Drawing.Point(12, 75);
			this.txtEnderecoIP.Name = "txtEnderecoIP";
			this.txtEnderecoIP.Size = new System.Drawing.Size(289, 31);
			this.txtEnderecoIP.TabIndex = 5;
			this.txtEnderecoIP.Text = "127.0.0.1";
			// 
			// txtPorta
			// 
			this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPorta.Location = new System.Drawing.Point(390, 75);
			this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.txtPorta.Name = "txtPorta";
			this.txtPorta.Size = new System.Drawing.Size(120, 31);
			this.txtPorta.TabIndex = 6;
			this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 450);
			this.Controls.Add(this.txtPorta);
			this.Controls.Add(this.txtEnderecoIP);
			this.Controls.Add(this.titulo);
			this.Controls.Add(this.txtPasta);
			this.Controls.Add(this.btnPararServidor);
			this.Controls.Add(this.btnEstabelecerConexao);
			this.Controls.Add(this.listaLogs);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listaLogs;
		private System.Windows.Forms.Button btnEstabelecerConexao;
		private System.Windows.Forms.Button btnPararServidor;
		private System.Windows.Forms.LinkLabel txtPasta;
		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.TextBox txtEnderecoIP;
		private System.Windows.Forms.NumericUpDown txtPorta;
	}
}

