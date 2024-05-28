using System;
using System.Windows.Forms;
using System.IO;

namespace Diretorio
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

            string path = @"c:\curso\";   //Pasta Raiz

            bool res = Directory.Exists(path + "logan");

            //lista.Items.Add(res);

            //if (!res)
            //{
            //    Directory.CreateDirectory(path + "logan");  // Se a pasta não existir ele cria uma pasta nova
            //}


            //if (res )
            //{
            //    Directory.Delete(path + "logan");
            //}


            //if (res )
            //{
            //    Directory.Move(path + "logan", path + @"destino\loganCopia");  //Move a pasta de local
            //}


            //string[] dirs = Directory.GetDirectories(path);  //Ele puxa todos os diretorios existentes que contem no path

            //foreach (string d in dirs) 
            //{
            //    lista.Items.Add(d);
            //}



            //string[] files = Directory.GetFiles(path);  //Ele puxa todos os aqruivos existentes que contem no path

            //foreach (string f in files)
            //{
            //    lista.Items.Add(f);
            //}


            //string root = Directory.GetDirectoryRoot(path); //Retorna a raiz de um determinado diretorio
            //lista.Items.Add(root);


            //string[] drivers = Directory.GetLogicalDrives();  //Retorna todas as unidades lógica da máquina
            //lista.Items.AddRange(drivers);


            //DirectoryInfo info = Directory.GetParent(path);      //Retorna a informação do path   
            //lista.Items.Add(info.FullName);


            string dir = Directory.GetCurrentDirectory();  //Retorna todo o diretorio atual que esta sendo executado
            lista.Items.Add(dir);
        }
    }
}

//Directory.Exists();
//Directory.CreateDirectory();
//Directory.Delete();
//Directory.Move();
//Directory.GetDirectories();
//Directory.GetFiles();
//Directory.GetDirectoryRoot();
//Directory.GetLogicalDrives();
//Directory.GetParent();
//Directory.GetCurrentDirectory();
