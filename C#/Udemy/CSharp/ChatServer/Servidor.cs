﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
	//Este delegate é necessário para especificar os parametros que estamos passando com o nosso evento
	public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
	 class Servidor
	{
		// Esta hashtable armazena os usuarios e as conexões (acessando/consultado por usuário)
		public static Hashtable htUsuarios = new Hashtable(30);  //30 usuarios é o limite definido

		public static Hashtable htConexoes = new Hashtable(30);

		//armazena o endereço IP passado
		private IPAddress enderecoIP;
		private int portaHost;
		private TcpClient tcpCliente;

		//O evento e o seu argumento irá notificar o formulário quando um usuário se conecta, desconecta, envia uma mensagem etc..
		public static event StatusChangedEventHandler StatusChanged;
		private static StatusChangedEventArgs e;

		//O construtor define o endereço IP para aquele retornado pela instancia do objeto
        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIP = endereco;
			portaHost = porta;
        }

		//A thread que ir atratar o escutador de conexões
		private Thread thrListener;

		//O objeto TCP object que escuta as conexões
		private TcpListener tlsCliente;

		//Ira dizer ao laço while para manter a monitoração das conexões
		bool ServRodando = false;

		//Inclui o usuário nas tabelas hash
		public static void IncluirUsuario(TcpClient tcpUsuario, string strUserName)
		{
			//Primeiro inclui o nome e conexão associada para ambas as hash tables
			Servidor.htUsuarios.Add(strUserName, tcpUsuario);
			Servidor.htConexoes.Add(tcpUsuario, strUserName);

			//Informa a nova conexão para todos os usuários e para o formulário do servidor
			EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou...");
		}

			//Remove o usuário das tabelas (hash tables)
		public static void RemoveUsuario(TcpClient tcpUsuario)
		{
			if (htConexoes[tcpUsuario] != null)
			{
				//Primeiro mostra a informações e informa os outros usuários sobre a conexão
				EnviaMensagemAdmin(htConexoes[tcpUsuario] + " saiu...");
				
				//Remove o usuário da hash table
				Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
				Servidor.htConexoes.Remove(tcpUsuario);
			}

		}

		//Este evento é chamado quando queremos disparar o evento StatusChanged
		public static void OnStatusChanged(StatusChangedEventArgs e)
		{
			StatusChangedEventHandler statusHandles = StatusChanged;

			if(statusHandles != null)
			{
				//invoca o delegate
				statusHandles(null, e);
			}
		}


		//Envia mensagem administrativas
		public static void EnviaMensagemAdmin(string Mensagem)
		{
			StreamWriter swSenderSender;

			//Exibe primeiro na aplicação
			e = new StatusChangedEventArgs("Administrador: " + Mensagem);
			OnStatusChanged(e);

			//Cria um array de clientes TCPs do tamanho do numero de cliente existentes
			TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
			//Copia os objetos TcpCLient no array
			Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

			//Percore a lista de cliente TCP
			for (int i = 0; i < tcpClientes.Length; i++)
			{
				//Tenta enviar uma mensagem para cada cliente
				try 
				{
					// Se a mensagem estiver em branco ou a conexão for nula sai...
					if(Mensagem.Trim() == "" || tcpClientes[i] == null)
					{
						continue;
					}

					//Envia a mensagem para o usuário atual no laço
					swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
					swSenderSender.WriteLine("Administrador: " + Mensagem);
					swSenderSender.Flush();
					swSenderSender = null;
				}
				catch 
				{
					//Se houver um problema, o usuário não existe,~então remove-o
					RemoveUsuario(tcpClientes[i]);
				}
			}
		}

		//Envia mensagens de um usuário para todos os outros
		public static void EnviaMensagem(string Origem, string Mensagem)
		{
			StreamWriter swSenderSender;

			//Primiero exibe a mensagem na aplicação
			e = new StatusChangedEventArgs(Origem + " disse : " + Mensagem);
			OnStatusChanged(e);

			//Cira um array de clientes TCPs do tamanho do numero de clientes existentes
			TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
			//Copia os objetos TcpClient no array
			Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);
			//Percorre a lista de clientes TCP

			for (int i = 0;i < tcpClientes.Length;i++)
			{
				//Tenta enviar uma mensagem para cada cliente
				try
				{
					// Se a mensagem estiver em branco ou a conexão for nula sai...
					if (Mensagem.Trim() == "" || tcpClientes[i] == null)
					{
						continue;
					}

					//Envia a mensagem para o usuário atual no laço
					swSenderSender = new StreamWriter(tcpClientes[i].GetStream());
					swSenderSender.WriteLine("Administrador: " + Mensagem);
					swSenderSender.Flush();
					swSenderSender = null;
				}
				catch
				{
					//Se houver um problema, o usuário não existe,~então remove-o
					RemoveUsuario(tcpClientes[i]);
				}
			}
		}

		public void IniciaAtendimento()
		{
			try
			{
				// Pega o IP
				IPAddress ipaLocal = enderecoIP;
				int portaLocal = portaHost;

				//Cira um objeto TCP listener usando o IP do servidor e porta definidas
				tlsCliente = new TcpListener(ipaLocal,portaLocal);

				//Inicia o TCP listener e escuta as conexões
				tlsCliente.Start();

				//O laço While verifica se o servidor esta rodando antes de checar as conexões
				ServRodando = true;

				//Inicia uma nova thread que hospeda o listner
				thrListener = new Thread(MantemAtendimento);
				thrListener.IsBackground = true; // Evita ficar no loopinfinito
				thrListener.Start();
			}
			catch  (Exception ex) 
			{
			
			}
		}

		private void MantemAtendimento()
		{
			//Enquanto o servidor estiver rodando 
			while(ServRodando)
			{
				//Aceita uma conexão pendente
				tcpCliente = tlsCliente.AcceptTcpClient();
				//Cria uma nova instância da conexão
				Conexao newConnection = new Conexao(tcpCliente);
			}
		}
    }
}
