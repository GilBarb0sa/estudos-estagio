using System;
using System.IO;
using System.Security.Cryptography;

namespace CriptoFile
{
	class Criptografia
	{
		//Declaração de CspParameters e RsaCryptoServiceProvider
		//Objetos com escopo global na classe.
		public static CspParameters cspp;
		public static RSACryptoServiceProvider rsa;

		//caminhos variaveis para a fonte, pasta de criptografia,
		//e pasta de descriptografia.
		private static string _encrFolder;
		public static string EncrFolder
		{
			get
			{
				return _encrFolder;
			}
			set
			{
				_encrFolder = value;
				//Definir o caminho
				PubKeyFile = _encrFolder + "rsaPublicKey.txt";
			} 
		}

		public static string DecrFolder { get; set; }
		public static string SrcFolder { get; set; }

		//Arquivo de chave publica
		private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

		//Chave contendo o nome para private/public key value pair.
		public static string keyName;

		//Método para criar a chave pública
		public static string CreateAsmKeys()
		{
			string result = "";

			//Armazena uma key pair na key container.
			if (string.IsNullOrEmpty(keyName))
			{
				result = "Chave pública não definida";
				return result;
			}

			cspp.KeyContainerName = keyName;
			rsa = new RSACryptoServiceProvider(cspp);
			rsa.PersistKeyInCsp = true;
			if (rsa.PublicOnly)
			{
				result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
			}
			else
			{
				result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
			}

			return result;
		}

		//Método para Exportar a chave pública a em um arquivo
		public static bool ExportPublicKey()
		{
			bool result = true;
			if (rsa == null)
			{
				result = false;
			}

			if (!Directory.Exists(EncrFolder))
			{
				Directory.CreateDirectory(EncrFolder);
			}

			StreamWriter sw = new StreamWriter(PubKeyFile, false);

			try
			{
				sw.Write(rsa.ToXmlString(false));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				result = false;
			}
			finally
			{
				sw.Close();
			}

			return result;
		}

		//Método para importar a chave pública de um arquivo
		public static string ImportPublicKey()
		{
			string result = "";

			if (!File.Exists(PubKeyFile))
			{
				result = "Arquivo de chave pública não encontrado.";
				return result;
			}

			if (string.IsNullOrEmpty(keyName))
			{
				result = "Chave pública não definida";
				return result;
			}

			StreamReader sr = new StreamReader(PubKeyFile);

			try
			{
				cspp.KeyContainerName = keyName;
				rsa = new RSACryptoServiceProvider(cspp);
				string keytxt = sr.ReadToEnd();
				rsa.FromXmlString(keytxt);
				rsa.PersistKeyInCsp = true;
				if (rsa.PublicOnly)
				{
					result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
				}
				else
				{
					result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
				}
			}
			catch (Exception ex)
			{
				result = ex.Message;
				Console.WriteLine(ex.Message);
			}
			finally
			{
				sr.Close();
			}

			return result;
		}

		//Método para criar uma chave privada à partir de um valor definido
		public static string GetPivateKey()
		{
			string result = "";
			if (string.IsNullOrEmpty(keyName))
			{
				result = "Chave privada não definida";
				return result;
			}

			cspp.KeyContainerName = keyName;
			rsa = new RSACryptoServiceProvider(cspp);
			rsa.PersistKeyInCsp = true ;

            if (rsa.PublicOnly)
            {
				result = "Key: " + cspp.KeyContainerName + " - Somente Pública";
            }
            else
            {
				result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
		}

		//Metódo para criptografar um arquivo
		public static string EncryptFile(string inFile)
		{
			//Criar uma instância de Aes para criptografia simétrica dos dados
			Aes aes = Aes.Create();
			ICryptoTransform transform = aes.CreateEncryptor();

			//Use RSACryptoServiceProvider para
			//criptografar a chave AES
			//rsa é insatanciado anteriormente: rsa = new RSACryptoService(cspp);
			byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

			//Crie matrizes de bytes para conter
			//os valores de comprimento da chave e IV.
			byte[] LenK = new byte[4];
			byte[] LenIV = new byte[4];

			int lKey = keyEncrypted.Length;
			LenK = BitConverter.GetBytes(lKey);
			int lIV = aes.IV.Length;
			LenIV = BitConverter.GetBytes(lIV);

			//Escreva o seguinte no FileStream
			//para o arquivo criptografado(outFiles);
			//-comprimento da chave
			//-comprimento do IV
			//-chave criptografada
			//-o IV
			//-o conteúdo da cifra criptografada

			int startFileName = inFile.LastIndexOf("\\") + 1;
			string outFile = EncrFolder + inFile.Substring(startFileName) + ".enc";

			try
			{
				using(FileStream outFs = new FileStream(outFile, FileMode.Create))
				{
					outFs.Write(LenK, 0, 4);
					outFs.Write(LenIV, 0, 4);
					outFs.Write(keyEncrypted, 0, lKey);
					outFs.Write(aes.IV, 0, lIV);

					//Agora escreva o texto cifrado usando um CryptoStream para criptografar.
					using(CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
					{
						//Ao criptografar um pedaço por vez, você pode economizar memória.
						int count = 0;
						int offset = 0;

						//blockSizeBytes pode ter qualquer tamanho arbitrário.
						int blockSizeBytes = aes.BlockSize / 8;
						byte[] data = new byte[blockSizeBytes];
						int bytesRead = 0;

						using (FileStream inFs = new FileStream(inFile, FileMode.Open))
						{
							do
							{
								count = inFs.Read(data, 0, blockSizeBytes);
								offset += count;
								outStreamEncrypted.Write(data, 0, count);
							} while (count > 0);
							inFs.Close();
						}
						outStreamEncrypted.FlushFinalBlock();
						outStreamEncrypted.Close();
					}
					outFs.Close();
				}
			}
			catch(Exception ex)
			{
				return ex.Message
			}

			return $"Arquivo criptografado.\n Origem: {inFile}\n Destino: {outFile}";
		}

		//Metódo para descriptografar um arquivo
	}
}
