using System;
using System.IO;
using System.Windows.Forms;

//Sql Server CE    *Não foi possivel a instalação do SqlServerCE na Prefeitura, então não foi feito as referencias.*
//using System.Data.SqlServerCE;

//Sqlite           *Não foi feito as transferencias de pastas de referencias com as dll, pois nõa possivel o aesso devido a limitação das máquinas da prefeitura.
//using System.Data.SQLite;

//MySQL            *Não foi possivel a utlização do MySqLite devido a limitação de downloads e acessos das máquinas da PG*
//using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            #region SQL Sercer CE
            //string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";  //Retorna a pasta do executavel não incluindo o nome da pasta do executavel

            //string strConection = @"DataSource = " + baseDados + "; Password = '12345' ";  //Endereço onde vai ficar a pasta da base de dados

            //SqlCeEngine db = SqlCeEngine(strConection);

            //if (!File.Exist(baseDados))  //Se o baseDados não existe faça a criação da baseDados..
            //{
            //    db.CreateDatabase();
            //}
            //db.Dispose();   //Para liberar o recurso do db

            //SqlCeConnection conexao = new SqlCeConnection(strConection);  //Define a conexão com a base de dados e qual base de dados vai ser
            ////conexao.ConnectionString = strConection;

            //try    //Utilizar o try catch, tem um tratamento para caso aja erro
            //{
            //    conexao.Open();  // Abrir a conexão que foi definida a strConection

            //    labelResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar Sql Server CE \n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();  //Fecha a conexão que tinha sido definida
            //}
            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\dbSQLLite.db";  //Retorna a pasta do executavel não incluindo o nome da pasta do executavel

            //string strConection = @"Data Source = " + baseDados + "; Version = 3";  //Endereço onde vai ficar a pasta da base de dados

            //if (!File.Exist(baseDados))  //Se o baseDados não existe faça a criação de uma nova baseDados..
            //{
            //    SQLiteConnection.CreateFle(baseDados);
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConection);  //Define a conexão com a base de dados e qual base de dados vai ser
            ////conexao.ConnectionString = strConection;

            //try    //Utilizar o try catch, tem um tratamento para caso aja erro
            //{
            //    conexao.Open();  // Abrir a conexão que foi definida a strConection

            //    labelResultado.Text = "Conectado SqlLite";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar SqlLite \n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();  //Fecha a conexão que tinha sido definida
            //}

            //Observação a pequenas diferenças com SQL Server CE
            #endregion


            #region MySQL

            string strConnection = "server=127.0.0.1;User Id=root;password=saskaroth";  //String de conexão  com base de dados não criada
            //string strConnection1 = "server=127.0.0.1;User Id=root;database=curso_db;password=saskaroth";  //String de conexão com base de dados definida

            MySQLConnection conexao = new MySQLConnection(strConnection);
            //conexao.ConnectionString = strConnection;   //É passado o strConnection no construtor acima!

            try    //Utilizar o try catch, tem um tratamento para caso aja erro
            {
                conexao.Open();  // Abrir a conexão que foi definida a strConection
                labelResultado.Text = "Conectado MySQL";

                MySQLCommand comando = new MySQLCommand();

                comando.Connection = conexao;   //Definindo a conexão para o MySQLCommand
                comando.ComandText = "CREAT DATABASE IF NOT EXISTS curco_db";   //Comando para criar uma base de dados se não existir

                comando.ExecuteNonQuery();  //Comando para executar
                labelResultado.Text = "Base de Dados criada com sucesso!";

                comando.Dispose();  //Limpa os recursos ao final da execução
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao Conectar MySQL \n" + ex;
            }
            finally
            {
                conexao.Close();  //Fecha a conexão que tinha sido definida
            }

        }
    }
}
