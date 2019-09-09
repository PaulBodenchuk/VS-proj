using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Abstractions;

namespace Copy_With_FileSistem
{
    class CopyClass
    {
        private readonly IFileSystem _fileSystem;

        public CopyClass() : this(new FileSystem())
        {
                
        }
        public CopyClass(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void CopyFile(string sourceFilePath, string destinationDirectoryPath)
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
