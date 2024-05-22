namespace Parte025
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.url1 = new System.Windows.Forms.TextBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.btn1 = new System.Windows.Forms.Button();
			this.url2 = new System.Windows.Forms.TextBox();
			this.btn2 = new System.Windows.Forms.Button();
			this.webBrowser2 = new System.Windows.Forms.WebBrowser();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(706, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btn1);
			this.tabPage1.Controls.Add(this.webBrowser1);
			this.tabPage1.Controls.Add(this.url1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(698, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Browser 1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.webBrowser2);
			this.tabPage2.Controls.Add(this.btn2);
			this.tabPage2.Controls.Add(this.url2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(698, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Browser 2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// url1
			// 
			this.url1.Dock = System.Windows.Forms.DockStyle.Top;
			this.url1.Location = new System.Drawing.Point(3, 3);
			this.url1.Name = "url1";
			this.url1.Size = new System.Drawing.Size(692, 20);
			this.url1.TabIndex = 0;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 23);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(692, 398);
			this.webBrowser1.TabIndex = 1;
			// 
			// btn1
			// 
			this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn1.Location = new System.Drawing.Point(645, 3);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(50, 20);
			this.btn1.TabIndex = 2;
			this.btn1.Text = "Ir";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// url2
			// 
			this.url2.Dock = System.Windows.Forms.DockStyle.Top;
			this.url2.Location = new System.Drawing.Point(3, 3);
			this.url2.Name = "url2";
			this.url2.Size = new System.Drawing.Size(692, 20);
			this.url2.TabIndex = 0;
			// 
			// btn2
			// 
			this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn2.Location = new System.Drawing.Point(645, 3);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(50, 20);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "Ir";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// webBrowser2
			// 
			this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser2.Location = new System.Drawing.Point(3, 23);
			this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser2.Name = "webBrowser2";
			this.webBrowser2.Size = new System.Drawing.Size(692, 398);
			this.webBrowser2.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox url1;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.WebBrowser webBrowser2;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.TextBox url2;
	}
}

