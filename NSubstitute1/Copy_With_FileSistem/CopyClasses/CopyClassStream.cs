using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Abstractions;

namespace Copy_With_FileSistem
{
    class CopyClassStream
    {
        private readonly IFileSystem _fileSystem;

        public CopyClassStream() : this(new FileSystem()) { }

        public CopyClassStream(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void ConvertFirstLineToUpper(string inputFilePath)
        {
            string outputFilePath = Path.ChangeExtension(inputFilePath, ".out.txt");

            using (StreamReader inputReader = _fileSystem.File.OpenText(inputFilePath))
            using (StreamWriter outputWriter = _fileSystem.File.CreateText(outputFilePath))
            {
                bool isFirstLine = true;

                while (!inputReader.EndOfStream)
                {
                    string line = inputReader.ReadLine();

                    if (isFirstLine)
                    {
                        line = line.ToUpperInvariant();
                        isFirstLine = false;
                    }

                    outputWriter.WriteLine(line);
                }
            }
        }

        public void CopyVideo(string sourceFilePath, string destinationDirectoryPath)
        {
            if (!_fileSystem.Directory.Exists(destinationDirectoryPath))
            {
                _fileSystem.Directory.CreateDirectory(destinationDirectoryPath);
            }

            var fileName = _fileSystem.Path.GetFileName(sourceFilePath);
            var destFileName = _fileSystem.Path.Combine(destinationDirectoryPath, fileName);
            _fileSystem.File.Copy(sourceFilePath, destFileName);
        }
    }
}
