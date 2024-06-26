namespace GDIPlus
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
			this.picture = new System.Windows.Forms.PictureBox();
			this.btnDesenhar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			this.SuspendLayout();
			// 
			// picture
			// 
			this.picture.Location = new System.Drawing.Point(13, 13);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(692, 421);
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// btnDesenhar
			// 
			this.btnDesenhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDesenhar.Location = new System.Drawing.Point(481, 440);
			this.btnDesenhar.Name = "btnDesenhar";
			this.btnDesenhar.Size = new System.Drawing.Size(194, 55);
			this.btnDesenhar.TabIndex = 1;
			this.btnDesenhar.Text = "Desenhar";
			this.btnDesenhar.UseVisualStyleBackColor = true;
			this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 507);
			this.Controls.Add(this.btnDesenhar);
			this.Controls.Add(this.picture);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Button btnDesenhar;
	}
}

