using System;
using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Copy_With_FileSistem
{
    [TestFixture]
    class FileCopierTests
    {
        [Test]
        public void CopyFile_SourceFileExistsDestinationDirDoesNotExist_DestinationFileCopied()
        {
            // Arrange
            var mockFileSystem = new MockFileSystem();
            //Assert.AreEqual(".txt", mockFileSystem.IsPathFieldNull());
            mockFileSystem.AddFile(@"C:\file777.txt", MockFileData.NullObject);

            var cleanFileCopier = new CopyClass(mockFileSystem);

            // Act
            cleanFileCopier.CopyFile(@"C:\file777.txt", @"C:\Users\pb3465\Desktop\TestF2");

            // Assert
            Assert.IsTrue(mockFileSystem.File.Exists(@"C:\Users\pb3465\Desktop\TestF2\file777.txt"));
        }
    }
}
