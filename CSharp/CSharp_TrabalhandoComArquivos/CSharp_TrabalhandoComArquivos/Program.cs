using System;
using System.IO;

namespace CSharp_TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Directory e DirectoryInfo

            var folderName = "pasta";
            var subFolderName = "subpasta";
            var subFolderNameStatic = "subpasta_usingstatic";

            var directoryInfoSubFolder = new DirectoryInfo(subFolderName);  //instanciando o directoryinfo da subpasta, mas ela não existe ainda

            if (!Directory.Exists(subFolderName) || !directoryInfoSubFolder.Exists) //Verifica se existe
            {
                Directory.CreateDirectory(subFolderNameStatic); //Cria os diretorios
                Directory.CreateDirectory(folderName);
                directoryInfoSubFolder.Create(); // utiliza quando estiver instanciado

                directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}"); //Move a subpasta para dentro da pasta
                Directory.Move(subFolderNameStatic, @$"{folderName}\{subFolderNameStatic}"); //Move tbm a subpasta_usingstatic para a pasta
            }

            var name = directoryInfoSubFolder.Name;
            var parent = directoryInfoSubFolder.Parent;
            var root = directoryInfoSubFolder.Root;
            var exists = directoryInfoSubFolder.Exists;

            foreach (var directory in Directory.GetDirectories(folderName))  //Faz uma revisão verificando as pastas dentro deste diretorio
            {
                Console.WriteLine(directory);
            }

            Directory.Delete($@"{folderName}\{subFolderName}"); // Apaga o diretorio subpasta que esta dentro da pasta

            #endregion

            #region File e FileInfo

            var file = @"pasta\texto.txt"; //@ para poder usar uma contrabarra e para criação de um txt

            if (!File.Exists(file)) //Verifica se existe no modo estatico
            {
                File.CreateText(file); //Senão existe cria uma pasta para este caminho
            }

            var fileInfo = new FileInfo(file); //Inicializa 

            Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de atualização: {fileInfo.LastWriteTime}"); //Imprime informações no console, sobre o arquivo criado

            #endregion

            Console.ReadKey();
        }
    }
}
