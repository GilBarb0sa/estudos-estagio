namespace CriptoFile
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.btnEncryptFIle = new System.Windows.Forms.Button();
			this.btnDecryptFile = new System.Windows.Forms.Button();
			this.btnCreateAsmKeys = new System.Windows.Forms.Button();
			this.btnGetPrivateKey = new System.Windows.Forms.Button();
			this.btnImportPublicKey = new System.Windows.Forms.Button();
			this.btnExportPublicKeys = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 135);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chave não definida";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtKey
			// 
			this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKey.Location = new System.Drawing.Point(186, 174);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(295, 31);
			this.txtKey.TabIndex = 1;
			// 
			// btnEncryptFIle
			// 
			this.btnEncryptFIle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncryptFIle.Location = new System.Drawing.Point(20, 273);
			this.btnEncryptFIle.Name = "btnEncryptFIle";
			this.btnEncryptFIle.Size = new System.Drawing.Size(207, 52);
			this.btnEncryptFIle.TabIndex = 2;
			this.btnEncryptFIle.Text = "Criptografia arquivo";
			this.btnEncryptFIle.UseVisualStyleBackColor = true;
			this.btnEncryptFIle.Click += new System.EventHandler(this.btnEncryptFIle_Click);
			// 
			// btnDecryptFile
			// 
			this.btnDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDecryptFile.Location = new System.Drawing.Point(233, 273);
			this.btnDecryptFile.Name = "btnDecryptFile";
			this.btnDecryptFile.Size = new System.Drawing.Size(207, 52);
			this.btnDecryptFile.TabIndex = 3;
			this.btnDecryptFile.Text = "Descriptografar arquivo";
			this.btnDecryptFile.UseVisualStyleBackColor = true;
			this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
			// 
			// btnCreateAsmKeys
			// 
			this.btnCreateAsmKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateAsmKeys.Location = new System.Drawing.Point(446, 273);
			this.btnCreateAsmKeys.Name = "btnCreateAsmKeys";
			this.btnCreateAsmKeys.Size = new System.Drawing.Size(207, 52);
			this.btnCreateAsmKeys.TabIndex = 4;
			this.btnCreateAsmKeys.Text = "Criar chaves";
			this.btnCreateAsmKeys.UseVisualStyleBackColor = true;
			this.btnCreateAsmKeys.Click += new System.EventHandler(this.btnCreateAsmKeys_Click);
			// 
			// btnGetPrivateKey
			// 
			this.btnGetPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetPrivateKey.Location = new System.Drawing.Point(446, 349);
			this.btnGetPrivateKey.Name = "btnGetPrivateKey";
			this.btnGetPrivateKey.Size = new System.Drawing.Size(207, 52);
			this.btnGetPrivateKey.TabIndex = 7;
			this.btnGetPrivateKey.Text = "Obter chave privada";
			this.btnGetPrivateKey.UseVisualStyleBackColor = true;
			this.btnGetPrivateKey.Click += new System.EventHandler(this.btnGetPrivateKey_Click);
			// 
			// btnImportPublicKey
			// 
			this.btnImportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportPublicKey.Location = new System.Drawing.Point(233, 349);
			this.btnImportPublicKey.Name = "btnImportPublicKey";
			this.btnImportPublicKey.Size = new System.Drawing.Size(207, 52);
			this.btnImportPublicKey.TabIndex = 6;
			this.btnImportPublicKey.Text = "Importar chave pública";
			this.btnImportPublicKey.UseVisualStyleBackColor = true;
			this.btnImportPublicKey.Click += new System.EventHandler(this.btnImportPublicKey_Click);
			// 
			// btnExportPublicKeys
			// 
			this.btnExportPublicKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportPublicKeys.Location = new System.Drawing.Point(20, 349);
			this.btnExportPublicKeys.Name = "btnExportPublicKeys";
			this.btnExportPublicKeys.Size = new System.Drawing.Size(207, 52);
			this.btnExportPublicKeys.TabIndex = 5;
			this.btnExportPublicKeys.Text = "Exportar chave pública";
			this.btnExportPublicKeys.UseVisualStyleBackColor = true;
			this.btnExportPublicKeys.Click += new System.EventHandler(this.btnExportPublicKeys_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 450);
			this.Controls.Add(this.btnGetPrivateKey);
			this.Controls.Add(this.btnImportPublicKey);
			this.Controls.Add(this.btnExportPublicKeys);
			this.Controls.Add(this.btnCreateAsmKeys);
			this.Controls.Add(this.btnDecryptFile);
			this.Controls.Add(this.btnEncryptFIle);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Button btnEncryptFIle;
		private System.Windows.Forms.Button btnDecryptFile;
		private System.Windows.Forms.Button btnCreateAsmKeys;
		private System.Windows.Forms.Button btnGetPrivateKey;
		private System.Windows.Forms.Button btnImportPublicKey;
		private System.Windows.Forms.Button btnExportPublicKeys;
	}
}

