using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStreamsTry
{
    class Program
    {
        static void Main(string[] args)
        {
            //var streamOne = new MemoryStream();

            //FillThisStreamUp(streamOne);
            //var streamTwo = new MemoryStream();
            //DoSomethingToThisStreamLol(streamTwo);
            //streamTwo.CopyTo(streamOne);

            string filePath1 = @"C:\Users\pb3465\Documents\Participant Participant1 Recording1 Video.mp4";
            string filePath2 = @"C:\Users\pb3465\Documents\Participant Participant1 Recording1 Audio.mp4";

            string saveFilePath = @"C:\Users\pb3465\Documents\RESULT.mp4";

            using (FileStream fileStreamVideo = File.OpenRead(filePath1))
            {
                //create new MemoryStream object
                MemoryStream memStreamVideo = new MemoryStream();
                memStreamVideo.SetLength(fileStreamVideo.Length);

                using (FileStream fileStreamAudio = File.OpenRead(filePath2))
                {

                    //create new MemoryStream object
                    MemoryStream memStreamAudio = new MemoryStream();
                    memStreamAudio.SetLength(fileStreamAudio.Length);
                    //read file to MemoryStream
                    memStreamAudio.CopyTo(memStreamVideo);
                }

                //File.Create(saveFilePath);
                using (FileStream fileStreamResult = File.Create(saveFilePath))
                {
                    memStreamVideo.CopyTo(fileStreamResult);
                }
            }
        }
    }
}
