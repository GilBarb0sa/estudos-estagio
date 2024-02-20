using System;

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

            var directoryInfoSubFolder = new DirectoryInfo(subFolderName);

            if (!directoryInfoSubFolder.Exists(subFolderName) || !directoryInfoSubFolder.Exists)
            {
                Directory.CreateDirectory(subFolderNameStatic);
                Directory.CreateDirectory(folderName);
                directoryInfoSubFolder.Create();

                directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}");
                Directory.Move(subFolderNameStatic, $@"{folderName}\{subFolderNameStatic}");
            }

            var name = directoryInfoSubFolder.Name;
            var parent = directoryInfoSubFolder.Parente;
            var root = directoryInfoSubFolder.Root;
            var exists = directoryInfoSubFolder.Exists;

            foreach (var directory in Directory.GetDirectories(folderName))
            {
                Console.WriteLine(directory);
            }

            Directory.Delete($@"{folderName}\{subFolderName}");

            #endregion
        }
    }
}
