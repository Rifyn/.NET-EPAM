using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_MANAGEMENT_SYSTEM
{
    public class ViewMode
    {
        private static ViewMode _instance;
        ConsoleUI consoleUI = ConsoleUI.GetInstance();
        private ViewMode()
        {

        }

        public static ViewMode GetInstance()
        {
            if (_instance == null)
                _instance = new ViewMode();
            return _instance;
        }

        public void Start(FileSystemWatcher watcher)
        {

            watcher.NotifyFilter = NotifyFilters.Attributes
                                         | NotifyFilters.CreationTime
                                         | NotifyFilters.DirectoryName
                                         | NotifyFilters.FileName
                                         | NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.Security
                                         | NotifyFilters.Size;

            watcher.Changed += consoleUI.OnChanged;
            watcher.Created += consoleUI.OnCreated;
            watcher.Deleted += consoleUI.OnDeleted;
            watcher.Renamed += consoleUI.OnRenamed;
            watcher.Error += consoleUI.OnError;

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }
    }
}
