namespace Parte007
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
			this.combo = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// combo
			// 
			this.combo.BackColor = System.Drawing.SystemColors.Control;
			this.combo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.combo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.combo.ForeColor = System.Drawing.SystemColors.Desktop;
			this.combo.FormattingEnabled = true;
			this.combo.Location = new System.Drawing.Point(12, 12);
			this.combo.Name = "combo";
			this.combo.Size = new System.Drawing.Size(728, 44);
			this.combo.TabIndex = 0;
			this.combo.Text = "--- Selecione um item ---";
			this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(541, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 61);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.combo);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.ComboBox combo;
		private System.Windows.Forms.Button button1;
	}
}

