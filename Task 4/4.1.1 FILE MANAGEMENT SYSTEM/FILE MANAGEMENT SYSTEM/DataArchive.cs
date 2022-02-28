using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace FILE_MANAGEMENT_SYSTEM
{
    public class DataArchive
    {
        private static DataArchive _instance;
        
        private DataArchive() { }
        public static DataArchive Instance()
        {
            if (_instance == null)
                _instance = new DataArchive();
            return _instance;
        }

        Dictionary<DateTime, Guid> datas = new Dictionary<DateTime, Guid>();

        public void Add()
        {
            Guid id = Guid.NewGuid();
            DateTime date = DateTime.Now;
            datas.Add(date, id);
            string fileName = "D:\\BackUp.txt";
            string jsonString = JsonConvert.SerializeObject(datas);
            File.WriteAllText(fileName, jsonString);
            ZipFile.CreateFromDirectory(@"D:\qwe", $"D:\\asd\\{id}.zip");
        }

        public void SetBackUp(DateTime dateTime)
        {
            string content = File.ReadAllText("D:\\BackUp.txt");
            var idAndDates = JsonConvert.DeserializeObject<Dictionary<DateTime, Guid>>(content);
            var zipId = from i in idAndDates
                        where i.Key == dateTime
                        select i.Value;
            ClearFoulder(@"D:\qwe");
            ZipFile.ExtractToDirectory("D:\\asd\\" + zipId.First() + ".zip", @"D:\qwe");
            ConsoleUI.GetInstance().Print("Откат выполнен!");
        }

        public void ClearFoulder(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public DateTime TryToConvert(string value)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(value);
                return dateTime;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }
    }
}
