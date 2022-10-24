using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8_Task_2
{
    internal class DirectoryExtension
    {
        public static long CountSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fis = d.GetFiles();
            foreach(FileInfo fi in fis)
            {
                size += fi.Length;
            }

            DirectoryInfo[] dis = d.GetDirectories();
            foreach(DirectoryInfo di in dis)
            {
                size += CountSize(di);
            }
            return size;
        }
    }
}
