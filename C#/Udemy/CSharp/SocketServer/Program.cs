using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);  //O servidor que o cliente irá acessar

			socket.Bind(endPoint);

			socket.Listen(5);

			Console.WriteLine("Escutando...");

			Socket escutar = socket.Accept();  //Retorna uma nova requisição, criando uma conexão com o socket

			byte[] bytes = new byte[255];

			int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None);

			Array.Resize(ref bytes,tamanho);

			Console.WriteLine("Cliente falou: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

			socket.Close();

            Console.WriteLine("Servidor Finalizado \n Pressione qualquer tecla para finalizar...");
			Console.ReadKey();

        }
	}
}
