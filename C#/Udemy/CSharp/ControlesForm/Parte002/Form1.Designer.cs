namespace Parte002
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
			this.btnExecutar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnExecutar
			// 
			this.btnExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExecutar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnExecutar.BackgroundImage = global::Parte002.Properties.Resources.car;
			this.btnExecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExecutar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.btnExecutar.FlatAppearance.BorderSize = 4;
			this.btnExecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnExecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExecutar.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExecutar.ForeColor = System.Drawing.Color.DarkGreen;
			this.btnExecutar.Location = new System.Drawing.Point(223, 154);
			this.btnExecutar.Name = "btnExecutar";
			this.btnExecutar.Size = new System.Drawing.Size(350, 150);
			this.btnExecutar.TabIndex = 0;
			this.btnExecutar.Text = "Executar";
			this.btnExecutar.UseVisualStyleBackColor = false;
			this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(756, 450);
			this.Controls.Add(this.btnExecutar);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExecutar;
	}
}

