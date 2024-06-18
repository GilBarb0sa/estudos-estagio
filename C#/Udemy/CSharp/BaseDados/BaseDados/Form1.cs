using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

//Sql Server CE    *Não foi possivel a instalação do SqlServerCE na Prefeitura, então não foi feito as referencias.*
using System.Data.SqlServerCE;

//Sqlite           *Não foi feito as transferencias de pastas de referencias com as dll, pois nõa possivel o aesso devido a limitação das máquinas da prefeitura.
using System.Data.SQLite;

//MySQL            *Não foi possivel a utlização do MySqLite devido a limitação de downloads e acessos das máquinas da PG*
using MySql.Data.MySqlClient;
using System.Data;

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

			#region SQL Server CE
			//string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; //string que contem o caminho da base de dados
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

			//string baseDados = Application.StartupPath + @"\db\DBSQLLite.db";  //string que contem o caminho da base de dados
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

			string strConnection = "server=127.0.0.1;User Id=root;password=saskaroth";  //string que contem o caminho da base de dados
																						//string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=saskaroth";  //String de conexão com base de dados definida

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
		#endregion

		private void btnCriarTabela_Click(object sender, EventArgs e)
		{
			#region SQLServer
			//string basedados = Application.StartupPath + @"\db\DBSQLerver.sdf";   //string que contem o caminho da base de dados
			//string strConection = @"DataSource = " + baseDados + "; Password = '12345' ";  //string de conexão  

			//SqlCeConnection conexao = new SqlCeConnection(strConection);   //é feito a conexão

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//    conexao.Open();  //Abri a conexão

			//    SqlCeCommand comando = new SqlCeCommand();
			//    comando.Connection = conexao;  //o comando irá trabalhar com base na conexão

			//    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";   //criar o comando da tabela;
			//    comando.ExecuteNonQuery();  //Executa o comando!

			//    labelResultado.Text = "Tabela Criada SqlServerCe";
			//    comando.Dispose();
			//}
			//catch (Exception ex) 
			//{
			//    labelResultado.Text = ex.Message;
			//}
			//finally
			//{
			//    conexao.Close();  //fecha a conexão
			//}
			#endregion

			#region SQLite
			//string baseDados = Application.StartupPath + @"\db\DBSQLLite.db";   //string que contem o caminho da base de dados
			//string strConection = @"Data Source = " + baseDados + "; Version = 3";  //string de conexão

			//SQLiteConnection conexao = new SQLiteConnection(strConection);   //é feito a conexão

			//try   //Try catch ajuda a execução não travar caso de algum erro
			//{
			//    conexao.Open();  //Abri a conexão

			//    SQLiteCommand comando = new SQLiteCommand();
			//    comando.Connection = conexao;  //o comando irá trabalhar com base na conexão

			//    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";   //criar o comando da tabela;
			//    comando.ExecuteNonQuery();  //Executa o comando!

			//    labelResultado.Text = "Tabela Criada SQLite";
			//    comando.Dispose();
			//}
			//catch (Exception ex)
			//{
			//    labelResultado.Text = ex.Message;
			//}
			//finally
			//{
			//    conexao.Close();  //fecha a conexão
			//}
			#endregion

			#region MySQL
			string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=saskaroth";  //string de conexão
			MySqlConnection conexao = new MySqlConnection(strConnection);   //é feito a conexão

			try   //Try catch ajuda a execução não travar caso de algum erro
			{
				conexao.Open();  //Abri a conexão

				MySqlCommand comando = new MySqlCommand();
				comando.Connection = conexao;  //o comando irá trabalhar com base na conexão

				comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KETY(id))";   //criar o comando da tabela;
				comando.ExecuteNonQuery();  //Executa o comando!

				labelResultado.Text = "Tabela Criada MySql";
				comando.Dispose();
			}
			catch (Exception ex)
			{
				labelResultado.Text = ex.Message;
			}
			finally
			{
				conexao.Close();  //fecha a conexão
			}
			#endregion
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{
			#region SQLServer
			//string basedados = Application.StartupPath + @"\db\DBSQLerver.sdf";  //string que contem o caminho da base de dados
			//string strConection = @"DataSource = " + baseDados + "; Password = '12345' ";  //string de conexão

			//SqlCeConnection conexao = new SqlCeConnection(strConection);   //é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//    conexao.Open();  //Abri a conexão com base de dados

			//    SqlCeCommand comando = new SqlCeCommand();
			//    comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

			//    int id = new Random(DateTime.Now.Millisecond).Next(0,1000);  //gera um numero inteiro aleatorio entre 0 e 1000
			//    string nome = textNome.Text; 
			//    string email = textEmail.Text;

			//    comando.CommandText = "INSERT INTO pessoas VALUES ("+ id + ", '" + nome + "', '" + email + "')";  //Comando Consulta  SQL
			//    comando.ExecuteNonQuery();  //Executa o comando!

			//    labelResultado.Text = "Registro inserido SqlServerCe";
			//    comando.Dispose();  //Libera recurso
			//}
			//catch (Exception ex)
			//{
			//    labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//    conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region SQLite
			//string baseDados = Application.StartupPath + @"\db\DBSQLLite.db"; //string que contem o caminho da base de dados
			//string strConection = @"Data Source = " + baseDados + "; Version = 3";  //string de conexão

			//SQLiteConnection conexao = new SQLiteConnection(strConection);   //é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//    conexao.Open();  //Abri a conexão com base de dados

			//    SQLiteCommand comando = new SQLiteCommand();
			//    comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

			//    int id = new Random(DateTime.Now.Millisecond).Next(0,1000);  //gera um numero inteiro aleatorio entre 0 e 1000
			//    string nome = textNome.Text;
			//    string email = textEmail.Text;

			//    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";  //Comando Consulta SQL
			//    comando.ExecuteNonQuery();  //Executa o comando!

			//    labelResultado.Text = "Registro inserido SQLite";
			//    comando.Dispose();  //Libera recurso
			//}
			//catch (Exception ex)
			//{
			//    labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//    conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region MySQL
			string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=saskaroth"; //string que contem o caminho da base de dados
			MySqlConnection conexao = new MySqlConnection(strConnection);    //é feito a conexão com a base de dados

			try  //Try catch ajuda a execução não travar caso de algum erro
			{
				conexao.Open();  //Abri a conexão com base de dados

				MySqlCommand comando = new MySqlCommand();
				comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

				int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);  //gera um numero inteiro aleatorio entre 0 e 1000
				string nome = textNome.Text;
				string email = textEmail.Text;

				comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";  //Comando Consulta SQL
				comando.ExecuteNonQuery();  //Executa o comando!

				labelResultado.Text = "Registro inserido MySql";
				comando.Dispose();  //Libera recurso
			}
			catch (Exception ex)
			{
				labelResultado.Text = ex.Message;  // exibe msgm de erro
			}
			finally
			{
				conexao.Close();  //fecha a conexão se der certo ou não
			}
			#endregion
		}

		private void btnProcurar_Click(object sender, EventArgs e)
		{

			labelResultado.Text = "";
			lista.Rows.Clear();

			#region SQLServerCE
			//string basedados = Application.StartupPath + @"\db\DBSQLerver.sdf";  //string que contem o caminho da base de dados
			//string strConection = @"DataSource = " + baseDados + "; Password = '12345' ";  //string de conexão

			//SqlCeConnection conexao = new SqlCeConnection(strConection);   //é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//    string query = "SELECT * FROM pessoas"; //Para recuperar todos os registros

			//    if(txtNome.Text != "")
			//    {
			//        query = "Select * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
			//    }

			//    DataTable dados = new DataTable();

			//    SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConection);

			//    conexao.Open();  //Abri a conexão com base de dados

			//    adaptador.Fill(dados);  

			//    foreach(DataRow linha in dados.Rows)
			//    {
			//        lista.Rows.Add(linha.ItemArray);
			//    }

			//}
			//catch (Exception ex)
			//{
			//    lista.Rows.Clear();
			//    labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//    conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region SQLite
			//string baseDados = Application.StartupPath + @"\db\DBSQLLite.db"; //string que contem o caminho da base de dados
			//string strConection = @"Data Source = " + baseDados + "; Version = 3";  //string de conexão

			//SQLiteConnection conexao = new SQLiteConnection(strConection);   //é feito a conexão com a base de dados


			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//	string query = "SELECT * FROM pessoas"; //Para recuperar todos os registros

			//	if (txtNome.Text != "")
			//	{
			//		query = "Select * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
			//	}

			//	DataTable dados = new DataTable();

			//	SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);  

			//	conexao.Open();  //Abri a conexão com base de dados

			//	adaptador.Fill(dados);

			//	foreach (DataRow linha in dados.Rows)
			//	{
			//		lista.Rows.Add(linha.ItemArray);
			//	}

			//}
			//catch (Exception ex)
			//{
			//	labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//	conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region MySql

			string baseDados = Application.StartupPath + @"\db\DBSQLLite.db"; //string que contem o caminho da base de dados
			string strConection = @"Data Source = " + baseDados + "; Version = 3";  //string de conexão

			MySqlConnection conexao = new MySqlConnection(strConection);   //é feito a conexão com a base de dados


			try  //Try catch ajuda a execução não travar caso de algum erro
			{
				string query = "SELECT * FROM pessoas"; //Para recuperar todos os registros

				if (txtNome.Text != "")
				{
					query = "Select * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
				}

				DataTable dados = new DataTable();

				MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConection);

				conexao.Open();  //Abri a conexão com base de dados

				adaptador.Fill(dados);

				foreach (DataRow linha in dados.Rows)
				{
					lista.Rows.Add(linha.ItemArray);
				}

			}
			catch (Exception ex)
			{
				labelResultado.Text = ex.Message;  // exibe msgm de erro
			}
			finally
			{
				conexao.Close();  //fecha a conexão se der certo ou não
			}

			#endregion
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			#region SQLServer
			//string basedados = Application.StartupPath + @"\db\DBSQLerver.sdf";  //string que contem o caminho da base de dados
			//string strConection = @"DataSource = " + baseDados + "; Password = '12345' ";  //string de conexão

			//SqlCeConnection conexao = new SqlCeConnection(strConection);   //objeto de conexão é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//	conexao.Open();  //Abri a conexão com base de dados

			//	SqlCeCommand comando = new SqlCeCommand();
			//	comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

			//	int id = (int)lista.SelectedRows[0].Cells[0].Value;  //recupera o id para utilizar na exclusão abaixo

			//	comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";  //O caminho que será excluido no banco de dados

			//	comando.ExecuteNonQuery();  //Executa o comando!

			//	labelResultado.Text = "Registro excluido Sql Server Ce";
			//	comando.Dispose();  //Libera recurso
			//}
			//catch (Exception ex)
			//{
			//	labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//	conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region SQLite
			//string baseDados = Application.StartupPath + @"\db\DBSQLLite.db"; //string que contem o caminho da base de dados
			//string strConection = @"Data Source = " + baseDados + "; Version = 3";  //string de conexão

			//SQLiteConnection conexao = new SQLiteConnection(strConection);   //é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//	conexao.Open();  //Abri a conexão com base de dados

			//	SQLiteCommand comando = new SQLiteCommand();

			//	comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

			//	int id = (int)lista.SelectedRows[0].Cells[0].Value;  //recupera o id para utilizar na exclusão abaixo

			//	comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";  //O caminho que será excluido no banco de dados

			//	comando.ExecuteNonQuery();  //Executa o comando!

			//	labelResultado.Text = "Registro excluido SQLite";
			//	comando.Dispose();  //Libera recurso
			//}
			//catch (Exception ex)
			//{
			//	labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//	conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region MySQL
			string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=saskaroth"; //string que contem o caminho da base de dados
			MySqlConnection conexao = new MySqlConnection(strConnection);    //é feito a conexão com a base de dados

			try  //Try catch ajuda a execução não travar caso de algum erro
			{
				conexao.Open();  //Abri a conexão com base de dados

				MySqlCommand comando = new MySqlCommand();
				comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

				int id = (int)lista.SelectedRows[0].Cells[0].Value;  //recupera o id para utilizar na exclusão abaixo

				comando.CommandText = "DELETE FROM pessoas WHERE id = '" + id + "'";  //O caminho que será excluido no banco de dados
				comando.ExecuteNonQuery();  //Executa o comando!

				labelResultado.Text = "Registro excluido MySql";
				comando.Dispose();  //Libera recurso
			}
			catch (Exception ex)
			{
				labelResultado.Text = ex.Message;  // exibe msgm de erro
			}
			finally
			{
				conexao.Close();  //fecha a conexão se der certo ou não
			}
			#endregion
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			#region SQLServer
			//string basedados = Application.StartupPath + @"\db\DBSQLerver.sdf";  //string que contem o caminho da base de dados
			//string strConection = @"DataSource = " + baseDados + "; Password = '12345' ";  //string de conexão

			//SqlCeConnection conexao = new SqlCeConnection(strConection);   //objeto de conexão é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//	conexao.Open();  //Abri a conexão com base de dados

			//	SqlCeCommand comando = new SqlCeCommand(); //Cria o comando que será passado para ser executado
			//	comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

			//	int id = (int)lista.SelectedRows[0].Cells[0].Value;  //recupera o id para utilizar na exclusão abaixo
			//	string nome = txtNome.Text;
			//	string email = txtEmail.Text;

			//	string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";  //Os campos que será alterado

			//	comando.CommandText = query;  //A consulta que será alterado no banco de dados

			//	comando.ExecuteNonQuery();  //Executa o comando!

			//	labelResultado.Text = "Registro alterado  Sql Server Ce";
			//	comando.Dispose();  //Libera recurso
			//}
			//catch (Exception ex)
			//{
			//	labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//	conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region SQLite
			//string baseDados = Application.StartupPath + @"\db\DBSQLLite.db"; //string que contem o caminho da base de dados
			//string strConection = @"Data Source = " + baseDados + "; Version = 3";  //string de conexão

			//SQLiteConnection conexao = new SQLiteConnection(strConection);   //é feito a conexão com a base de dados

			//try  //Try catch ajuda a execução não travar caso de algum erro
			//{
			//	conexao.Open();  //Abri a conexão com base de dados

			//	SQLiteCommand comando = new SQLiteCommand();

			//	comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

			//	int id = (int)lista.SelectedRows[0].Cells[0].Value;  //recupera o id para utilizar na exclusão abaixo
			//	string nome = txtNome.Text;
			//	string email = txtEmail.Text;

			//	string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";  //Os campos que será alterado

			//	comando.CommandText = query;  //O caminho que será excluido no banco de dados

			//	comando.ExecuteNonQuery();  //Executa o comando!

			//	labelResultado.Text = "Registro alterado SQLite";
			//	comando.Dispose();  //Libera recurso
			//}
			//catch (Exception ex)
			//{
			//	labelResultado.Text = ex.Message;  // exibe msgm de erro
			//}
			//finally
			//{
			//	conexao.Close();  //fecha a conexão se der certo ou não
			//}
			#endregion

			#region MySQL
			string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=saskaroth"; //string que contem o caminho da base de dados
			MySqlConnection conexao = new MySqlConnection(strConnection);    //é feito a conexão com a base de dados

			try  //Try catch ajuda a execução não travar caso de algum erro
			{
				conexao.Open();  //Abri a conexão com base de dados

				MySqlCommand comando = new MySqlCommand();
				comando.Connection = conexao;  //o comando irá trabalhar com a base na conexão

				int id = (int)lista.SelectedRows[0].Cells[0].Value;  //recupera o id para utilizar na exclusão abaixo
				string nome = txtNome.Text;
				string email = txtEmail.Text;

				string query = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";  //Os campos que será alterado

				comando.CommandText = query;  //O caminho que será excluido no banco de dados

				comando.ExecuteNonQuery();  //Executa o comando!

				labelResultado.Text = "Registro alterado MySql";
				comando.Dispose();  //Libera recurso
			}
			catch (Exception ex)
			{
				labelResultado.Text = ex.Message;  // exibe msgm de erro
			}
			finally
			{
				conexao.Close();  //fecha a conexão se der certo ou não
			}
			#endregion
		}
	}
}
