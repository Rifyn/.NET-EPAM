using System;
using System.IO;

namespace FILE_MANAGEMENT_SYSTEM
{
    public class Program
    {
        static void Main(string[] args)
        {
            ViewMode viewMode = ViewMode.GetInstance();
            DataArchive dataArchive = DataArchive.Instance();
            ConsoleUI consoleUI = ConsoleUI.GetInstance();
            using var watcher = new FileSystemWatcher(@"D:\qwe", "*.txt");
            consoleUI.Print("Выберите режим:\n" +
                            "1-отслеживание\n" +
                            "2-откат изменений");
            switch (consoleUI.Input())
            {
                case "1":
                    viewMode.Start(watcher);
                    consoleUI.Print("Нажмите чтобы выйти");
                    consoleUI.Input();
                    break;
                case "2":
                    consoleUI.Print("Введите дату сохранения");
                    DateTime savedData = dataArchive.TryToConvert(consoleUI.Input());
                    dataArchive.SetBackUp(savedData);
                    break;
                default:
                    break;
            }
        }        
    }
}
