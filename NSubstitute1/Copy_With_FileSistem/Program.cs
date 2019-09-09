using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;

namespace Copy_With_FileSistem
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = @"C:\Users\pb3465\Desktop\TestF1\TestVideo.mp4";
            var destPath = @"C:\Users\pb3465\Desktop\TestF2";

            //new CopyClass().CopyFile(sourcePath, destPath);
            //new CopyClassStream().ConvertFirstLineToUpper(sourcePath);
            new CopyClassStream().CopyVideo(sourcePath, destPath);


            //Console.ReadKey();
        }
    }
}
