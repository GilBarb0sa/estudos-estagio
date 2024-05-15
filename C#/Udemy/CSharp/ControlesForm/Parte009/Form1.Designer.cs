namespace Parte009
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
			this.link = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// link
			// 
			this.link.AutoSize = true;
			this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
			this.link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.link.LinkColor = System.Drawing.Color.DarkRed;
			this.link.Location = new System.Drawing.Point(12, 9);
			this.link.Name = "link";
			this.link.Size = new System.Drawing.Size(265, 33);
			this.link.TabIndex = 0;
			this.link.TabStop = true;
			this.link.Text = "Curso de C-Sharp";
			this.link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 450);
			this.Controls.Add(this.link);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel link;
	}
}

