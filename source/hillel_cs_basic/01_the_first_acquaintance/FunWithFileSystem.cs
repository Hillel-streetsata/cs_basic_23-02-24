using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace _01_the_first_acquaintance
{
    public class FunWithFileSystem
    {
        public void FileSystemInfoOut()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Environment.SystemDirectory); // windows/syste32 
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        public void DriveInfoOut()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.AvailableFreeSpace);
                Console.WriteLine(drive.DriveFormat);
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.VolumeLabel);
            }
        }

        public void FunWithDirectories()
        {
            // Create folder
            //Console.WriteLine(Path.GetFullPath(Environment.SpecialFolder.Personal.ToString()));
            var pathToNewFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Hillel", "Lesson17");

            //if (!Directory.Exists(pathToNewFolder))
            //{
            //    Directory.CreateDirectory(pathToNewFolder);
            //}

            if (Directory.Exists(pathToNewFolder))
            {
                Directory.Delete(pathToNewFolder, true);
            }

        }

        public void FunWithFiles()
        {
            var pathToNewFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Hillel", "Lesson17");
            var pathToNewFile = Path.Combine(pathToNewFolder, "Test.txt");
            var pathToBackupFile = Path.Combine(pathToNewFolder, "backup.txt");

            if (!Directory.Exists(pathToNewFolder))
            {
                Directory.CreateDirectory(pathToNewFolder);
            }

            //if (!File.Exists(pathToNewFile))
            //{
            //    StreamWriter text = new StreamWriter(pathToNewFile);
            //    text.WriteLine("Hello");
            //    text.Close();
            //}

            FileStreamOptions fileStreamOptions = new FileStreamOptions();
            fileStreamOptions.Mode = FileMode.Append;
            fileStreamOptions.Access = FileAccess.Write;
            StreamWriter text = new StreamWriter(pathToBackupFile, fileStreamOptions);
            text.WriteLine("123456");
            text.Close();

            //using (StreamReader sr = new StreamReader(pathToBackupFile))
            //{
            //    string line = sr.ReadToEnd();
            //    Console.WriteLine(line);
            //}

            //File.Copy(sourceFileName: pathToNewFile, destFileName: pathToBackupFile, true);

            //if (File.Exists(pathToNewFile))
            //{
            //    File.Delete(pathToNewFile);
            //}

            //StreamReader streamReader = new StreamReader(pathToBackupFile);
            //Console.WriteLine(streamReader.ReadToEnd());
            //streamReader.Close();

            //FileStream fileStream = File.Open(pathToBackupFile, FileMode.Append);
            //StreamWriter streamwriter1 = new StreamWriter(fileStream);
            //streamwriter1.WriteLine("jhgjhjjkhjk");
            //fileStream.Close();
            ////streamwriter1.Close();
        }

        public void FunWithFileInfo()
        {
            var pathToNewFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Hillel", "Lesson17");
            var pathToBackupFile = Path.Combine(pathToNewFolder, "backup.txt");

            //var atrr = File.GetAttributes(pathToBackupFile);
            //Console.WriteLine(atrr);

            Console.WriteLine(Path.GetFileName(pathToBackupFile));
            Console.WriteLine(Path.GetFileNameWithoutExtension(pathToBackupFile));
            Console.WriteLine(Path.GetExtension(pathToBackupFile));
            string randomFileName = Path.GetRandomFileName();
            Console.WriteLine(randomFileName);

            FileInfo fileInfo = new FileInfo(pathToBackupFile);

            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.Attributes);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.LastWriteTime);
        }

        public void SaveOurFile()
        {
            string[] arr = { "tes1", "test2", "test3" };

            string textFile = Path.Combine(Directory.GetCurrentDirectory(), "db.txt");

            StreamWriter text = File.CreateText(textFile);

            foreach (string item in arr)
            {
                text.WriteLine(item);
            }

            text.Close();

            Console.WriteLine(File.ReadAllText(textFile));
        }
    }


}
