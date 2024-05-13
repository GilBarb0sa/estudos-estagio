namespace Formularios
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnSegunda = new System.Windows.Forms.Button();
			this.btnSegundaFormThread = new System.Windows.Forms.Button();
			this.menuBar = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpSobreDev = new System.Windows.Forms.ToolStripMenuItem();
			this.mHelpSobreVer = new System.Windows.Forms.ToolStripMenuItem();
			this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
			this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
			this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
			this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 100);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(744, 156);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Principal";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSegunda
			// 
			this.btnSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSegunda.Location = new System.Drawing.Point(12, 375);
			this.btnSegunda.Name = "btnSegunda";
			this.btnSegunda.Size = new System.Drawing.Size(181, 63);
			this.btnSegunda.TabIndex = 1;
			this.btnSegunda.Text = "Segunda Form";
			this.btnSegunda.UseVisualStyleBackColor = true;
			this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
			// 
			// btnSegundaFormThread
			// 
			this.btnSegundaFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSegundaFormThread.Location = new System.Drawing.Point(199, 375);
			this.btnSegundaFormThread.Name = "btnSegundaFormThread";
			this.btnSegundaFormThread.Size = new System.Drawing.Size(199, 63);
			this.btnSegundaFormThread.TabIndex = 2;
			this.btnSegundaFormThread.Text = "Segunda Form Thread";
			this.btnSegundaFormThread.UseVisualStyleBackColor = true;
			this.btnSegundaFormThread.Click += new System.EventHandler(this.btnSegundaFormThread_Click);
			// 
			// menuBar
			// 
			this.menuBar.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.mPesquisar});
			this.menuBar.Location = new System.Drawing.Point(0, 0);
			this.menuBar.Name = "menuBar";
			this.menuBar.Size = new System.Drawing.Size(781, 27);
			this.menuBar.TabIndex = 3;
			this.menuBar.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFileSair});
			this.menuFile.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(44, 23);
			this.menuFile.Text = "File";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// mFileSair
			// 
			this.mFileSair.BackColor = System.Drawing.Color.GreenYellow;
			this.mFileSair.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mFileSair.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.mFileSair.Image = global::Formularios.Properties.Resources.sair;
			this.mFileSair.Name = "mFileSair";
			this.mFileSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.mFileSair.Size = new System.Drawing.Size(180, 22);
			this.mFileSair.Text = "Sair";
			this.mFileSair.Click += new System.EventHandler(this.mFileSair_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
			this.menuHelp.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(49, 23);
			this.menuHelp.Text = "Help";
			// 
			// mHelpSobre
			// 
			this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDev,
            this.mHelpSobreVer});
			this.mHelpSobre.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mHelpSobre.Name = "mHelpSobre";
			this.mHelpSobre.Size = new System.Drawing.Size(180, 22);
			this.mHelpSobre.Text = "Sobre";
			// 
			// mHelpSobreDev
			// 
			this.mHelpSobreDev.Name = "mHelpSobreDev";
			this.mHelpSobreDev.Size = new System.Drawing.Size(152, 22);
			this.mHelpSobreDev.Text = "Desenvolvedor";
			this.mHelpSobreDev.Click += new System.EventHandler(this.mHelpSobreDev_Click);
			// 
			// mHelpSobreVer
			// 
			this.mHelpSobreVer.Name = "mHelpSobreVer";
			this.mHelpSobreVer.Size = new System.Drawing.Size(152, 22);
			this.mHelpSobreVer.Text = "Versão";
			this.mHelpSobreVer.Click += new System.EventHandler(this.mHelpSobreVer_Click);
			// 
			// comboMenu
			// 
			this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Espanhol",
            "Português"});
			this.comboMenu.Name = "comboMenu";
			this.comboMenu.Size = new System.Drawing.Size(121, 23);
			this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
			// 
			// mPesquisar
			// 
			this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.mPesquisar.Name = "mPesquisar";
			this.mPesquisar.Size = new System.Drawing.Size(200, 23);
			this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mPesquisar_KeyUp);
			// 
			// mFileNovo
			// 
			this.mFileNovo.BackColor = System.Drawing.Color.GreenYellow;
			this.mFileNovo.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mFileNovo.Image = global::Formularios.Properties.Resources.novo_documento;
			this.mFileNovo.Name = "mFileNovo";
			this.mFileNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mFileNovo.Size = new System.Drawing.Size(180, 22);
			this.mFileNovo.Text = "Novo";
			this.mFileNovo.Click += new System.EventHandler(this.mFileNovo_Click);
			// 
			// mFileAbrir
			// 
			this.mFileAbrir.BackColor = System.Drawing.Color.GreenYellow;
			this.mFileAbrir.Enabled = false;
			this.mFileAbrir.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mFileAbrir.Image = global::Formularios.Properties.Resources.abrir;
			this.mFileAbrir.Name = "mFileAbrir";
			this.mFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
			this.mFileAbrir.Text = "Abrir";
			this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 450);
			this.Controls.Add(this.btnSegundaFormThread);
			this.Controls.Add(this.btnSegunda);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.menuBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuBar;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulario Principal";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuBar.ResumeLayout(false);
			this.menuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnSegunda;
		private System.Windows.Forms.Button btnSegundaFormThread;
		private System.Windows.Forms.MenuStrip menuBar;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem mFileNovo;
		private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mFileSair;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
		private System.Windows.Forms.ToolStripMenuItem mHelpSobreDev;
		private System.Windows.Forms.ToolStripMenuItem mHelpSobreVer;
		private System.Windows.Forms.ToolStripComboBox comboMenu;
		private System.Windows.Forms.ToolStripTextBox mPesquisar;
	}
}

