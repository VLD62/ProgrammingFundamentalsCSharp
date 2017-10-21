using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] filePaths = Directory.GetFiles("C:\\Users\\Win10\\Dev");

            long sizeBytes = 0;

            foreach (var path in filePaths) {

                FileInfo fileInfo = new FileInfo(path);
                sizeBytes += fileInfo.Length;
            }

            double sizeMegabytes = (double)sizeBytes / (double)(1024 * 1024);

            File.WriteAllText("C:\\Users\\Win10\\Dev\\filesize.txt",sizeMegabytes.ToString());
        }
    }
}
