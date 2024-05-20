namespace Parte014
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
			this.button1 = new System.Windows.Forms.Button();
			this.picture = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 356);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 80);
			this.button1.TabIndex = 1;
			this.button1.Text = "CSharp";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// picture
			// 
			this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picture.Location = new System.Drawing.Point(12, 12);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(674, 326);
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(255, 356);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 80);
			this.button2.TabIndex = 2;
			this.button2.Text = "Camaro";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(486, 356);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(200, 80);
			this.button3.TabIndex = 3;
			this.button3.Text = "Castelo";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.picture);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

