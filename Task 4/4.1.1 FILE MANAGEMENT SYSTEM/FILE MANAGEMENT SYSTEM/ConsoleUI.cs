using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE_MANAGEMENT_SYSTEM
{
    public class ConsoleUI
    {
        private static ConsoleUI _instance;
        DataArchive dataArchive = DataArchive.Instance();
        private ConsoleUI()
        {
            
        }

        public static ConsoleUI GetInstance()
        {
            if (_instance == null)
                _instance = new ConsoleUI();
            return _instance;
        }
        public void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Изменено: {e.FullPath}");
            dataArchive.Add();
        }

        public void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Создано: {e.FullPath}";
            Console.WriteLine(value);
            dataArchive.Add();
        }

        public void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Удалено: {e.FullPath}");
            dataArchive.Add();
        }
            

        public void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Переименовано:");
            Console.WriteLine($"    Старое: {e.OldFullPath}");
            Console.WriteLine($"    Новое: {e.FullPath}");
            dataArchive.Add();
        }

        public void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        public void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }

        public string Input()
        {
            return Console.ReadLine();
        }
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
