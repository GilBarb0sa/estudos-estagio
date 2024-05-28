using System;
using System.Windows.Forms;
using System.IO;

namespace ArquivoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            FileInfo info = new FileInfo(@"c:\curso\teste2.txt");

            if (info.Exists ) 
            { 
                lista.Items.Add(info.FullName);
                lista.Items.Add(info.Name);
                lista.Items.Add(info.Extension);
                lista.Items.Add(info.Directory.FullName);
                lista.Items.Add(info.DirectoryName);
                lista.Items.Add(info.CreationTime);
                lista.Items.Add(info.IsReadOnly);
                lista.Items.Add(info.LastAccessTime);
            }
            else
            {
                lista.Items.Add("Arquivo não existe!");
            }
        }
    }
}
