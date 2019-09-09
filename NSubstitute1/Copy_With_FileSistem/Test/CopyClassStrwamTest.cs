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
    class CopyClassStrwamTest
    {
        [Test]
        public void CheckFirstStringUpperTest()
        {
            var mockFileSystem = new MockFileSystem();
            var mockInputFile = new MockFileData("line1\nline2\nline3");
            mockFileSystem.AddFile(@"C:\temp\in.txt", mockInputFile);
            var sut = new CopyClassStream(mockFileSystem);
            sut.ConvertFirstLineToUpper(@"C:\temp\in.txt");
            MockFileData mockOutputFile = mockFileSystem.GetFile(@"C:\temp\in.out.txt");
            var bytes = mockOutputFile.Contents;
            string[] outputLines = mockOutputFile.TextContents.SplitLines();
            Assert.AreEqual("LINE1", outputLines[0]);
            Assert.AreEqual("line2", outputLines[1]);
            Assert.AreEqual("line3", outputLines[2]);
        }

        [Test]
        public void CopyVideoTest()
        {
            var mockFileSystem = new MockFileSystem();
            mockFileSystem.AddFile(@"C:\temp\in.mp4", MockFileData.NullObject);
            var sut = new CopyClassStream(mockFileSystem);
            sut.CopyVideo(@"C:\temp\in.mp4", @"C:\Users\pb3465\Desktop\TestF2");
            Assert.IsTrue(mockFileSystem.File.Exists(@"C:\Users\pb3465\Desktop\TestF2\in.mp4"));
        }
    }
}
