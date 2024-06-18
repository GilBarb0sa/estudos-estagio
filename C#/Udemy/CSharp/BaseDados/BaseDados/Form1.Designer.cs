namespace BaseDados
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
			this.labelResultado = new System.Windows.Forms.Label();
			this.lista = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelNome = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textNome = new System.Windows.Forms.TextBox();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.btnCriarTabela = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnProcurar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
			this.SuspendLayout();
			// 
			// labelResultado
			// 
			this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResultado.Location = new System.Drawing.Point(17, 12);
			this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(674, 122);
			this.labelResultado.TabIndex = 0;
			this.labelResultado.Text = "Resultado";
			// 
			// lista
			// 
			this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.lista.BackgroundColor = System.Drawing.SystemColors.Control;
			this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email});
			this.lista.Location = new System.Drawing.Point(21, 207);
			this.lista.MultiSelect = false;
			this.lista.Name = "lista";
			this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.lista.Size = new System.Drawing.Size(538, 280);
			this.lista.TabIndex = 1;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			// 
			// nome
			// 
			this.nome.HeaderText = "NOME";
			this.nome.Name = "nome";
			// 
			// email
			// 
			this.email.HeaderText = "EMAIL";
			this.email.Name = "email";
			// 
			// labelNome
			// 
			this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNome.Location = new System.Drawing.Point(22, 137);
			this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelNome.Name = "labelNome";
			this.labelNome.Size = new System.Drawing.Size(537, 29);
			this.labelNome.TabIndex = 2;
			this.labelNome.Text = "Nome:";
			// 
			// labelEmail
			// 
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEmail.Location = new System.Drawing.Point(21, 172);
			this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(538, 29);
			this.labelEmail.TabIndex = 3;
			this.labelEmail.Text = "E-mail:";
			// 
			// textNome
			// 
			this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNome.Location = new System.Drawing.Point(128, 137);
			this.textNome.Name = "textNome";
			this.textNome.Size = new System.Drawing.Size(431, 29);
			this.textNome.TabIndex = 4;
			// 
			// textEmail
			// 
			this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEmail.Location = new System.Drawing.Point(127, 172);
			this.textEmail.Name = "textEmail";
			this.textEmail.Size = new System.Drawing.Size(432, 29);
			this.textEmail.TabIndex = 5;
			// 
			// btnConectar
			// 
			this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConectar.Location = new System.Drawing.Point(579, 207);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(113, 28);
			this.btnConectar.TabIndex = 6;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// btnCriarTabela
			// 
			this.btnCriarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCriarTabela.Location = new System.Drawing.Point(579, 245);
			this.btnCriarTabela.Name = "btnCriarTabela";
			this.btnCriarTabela.Size = new System.Drawing.Size(113, 28);
			this.btnCriarTabela.TabIndex = 7;
			this.btnCriarTabela.Text = "Criar Tabela";
			this.btnCriarTabela.UseVisualStyleBackColor = true;
			this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.Location = new System.Drawing.Point(579, 279);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(113, 28);
			this.btnInserir.TabIndex = 8;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// btnProcurar
			// 
			this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcurar.Location = new System.Drawing.Point(579, 313);
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(113, 28);
			this.btnProcurar.TabIndex = 9;
			this.btnProcurar.Text = "Procurar";
			this.btnProcurar.UseVisualStyleBackColor = true;
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(580, 347);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(113, 28);
			this.btnExcluir.TabIndex = 10;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(580, 381);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(113, 28);
			this.btnEditar.TabIndex = 11;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 499);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnProcurar);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.btnCriarTabela);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.textEmail);
			this.Controls.Add(this.textNome);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelNome);
			this.Controls.Add(this.lista);
			this.Controls.Add(this.labelResultado);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}

