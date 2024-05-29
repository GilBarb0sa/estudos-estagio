namespace LerEscrever
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
            this.btnEscrevertxt = new System.Windows.Forms.Button();
            this.btnLerTxt = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.btnLerBinary = new System.Windows.Forms.Button();
            this.btnEscreverBinary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscrevertxt
            // 
            this.btnEscrevertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscrevertxt.Location = new System.Drawing.Point(13, 393);
            this.btnEscrevertxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEscrevertxt.Name = "btnEscrevertxt";
            this.btnEscrevertxt.Size = new System.Drawing.Size(155, 70);
            this.btnEscrevertxt.TabIndex = 1;
            this.btnEscrevertxt.Text = "Escrever Txt";
            this.btnEscrevertxt.UseVisualStyleBackColor = true;
            this.btnEscrevertxt.Click += new System.EventHandler(this.btnEscrevertxt_Click);
            // 
            // btnLerTxt
            // 
            this.btnLerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerTxt.Location = new System.Drawing.Point(176, 393);
            this.btnLerTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLerTxt.Name = "btnLerTxt";
            this.btnLerTxt.Size = new System.Drawing.Size(155, 70);
            this.btnLerTxt.TabIndex = 2;
            this.btnLerTxt.Text = "Ler Txt";
            this.btnLerTxt.UseVisualStyleBackColor = true;
            this.btnLerTxt.Click += new System.EventHandler(this.btnLerTxt_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(12, 12);
            this.txtConteudo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtConteudo.Size = new System.Drawing.Size(664, 358);
            this.txtConteudo.TabIndex = 3;
            this.txtConteudo.Text = "";
            // 
            // btnLerBinary
            // 
            this.btnLerBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerBinary.Location = new System.Drawing.Point(358, 393);
            this.btnLerBinary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLerBinary.Name = "btnLerBinary";
            this.btnLerBinary.Size = new System.Drawing.Size(155, 70);
            this.btnLerBinary.TabIndex = 4;
            this.btnLerBinary.Text = "Ler Binary";
            this.btnLerBinary.UseVisualStyleBackColor = true;
            this.btnLerBinary.Click += new System.EventHandler(this.btnLerBinary_Click);
            // 
            // btnEscreverBinary
            // 
            this.btnEscreverBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscreverBinary.Location = new System.Drawing.Point(521, 393);
            this.btnEscreverBinary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEscreverBinary.Name = "btnEscreverBinary";
            this.btnEscreverBinary.Size = new System.Drawing.Size(155, 70);
            this.btnEscreverBinary.TabIndex = 5;
            this.btnEscreverBinary.Text = "Escrever Binary";
            this.btnEscreverBinary.UseVisualStyleBackColor = true;
            this.btnEscreverBinary.Click += new System.EventHandler(this.btnEscreverBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 475);
            this.Controls.Add(this.btnEscreverBinary);
            this.Controls.Add(this.btnLerBinary);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.btnLerTxt);
            this.Controls.Add(this.btnEscrevertxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscrevertxt;
        private System.Windows.Forms.Button btnLerTxt;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.Button btnLerBinary;
        private System.Windows.Forms.Button btnEscreverBinary;
    }
}

