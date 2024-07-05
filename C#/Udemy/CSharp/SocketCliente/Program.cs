using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketCliente
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			try
			{
				IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);  //O servidor que o cliente irá acessar
			
				socket.Connect(endPoint);

                Console.WriteLine("Conectando com exito..");
                Console.WriteLine("Insira a informação para enviar: ");
                Console.WriteLine();

				string info = Console.ReadLine();

				byte[] infoEnviar = Encoding.Default.GetBytes(info);

				socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);
            }
			catch (Exception)
			{
                Console.WriteLine("Não foi possível conectar ao servidor...");
            }

			socket.Close();

            Console.WriteLine("presione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
	}
}
