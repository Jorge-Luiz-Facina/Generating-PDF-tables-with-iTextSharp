using Generating_PDF_with_iTextSharp.Table;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Test.Tests
{
    public class PDFFormatTableGeneratorTest
    {
        [Fact]
        public void PDFFormatTableGeneratorParameterArchiveNameTest()
        {
            string archiveName = "test";
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator(archiveName);
            Assert.Equal(true, File.Exists(Directory.GetCurrentDirectory() + "\\" + archiveName + ".pdf"));
        }

        [Fact]
        public void PDFFormatTableGeneratorParameterDefaultArchiveNameTest()
        {
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator();
            Assert.Equal(true, File.Exists(Directory.GetCurrentDirectory() + "\\" + PDFFormatTableGenerator.ARCHIVE_NAME + ".pdf"));
        }

        [Fact]
        public void setNameArchivePDFTest()
        {
            string archiveName = "newArchive";
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator("new");
            pDFFormatTableGenerator.setNameArchivePDF(archiveName);
            Assert.Equal(true, File.Exists(Directory.GetCurrentDirectory() + "\\" + archiveName + ".pdf"));
        }

        [Fact]
        public void setNameUserZeroNumbersColumns()
        {
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator("setNameUserZeroNumbersColumns");
            ArgumentException ex = Assert.Throws<ArgumentException>(() => pDFFormatTableGenerator.setNameUser(ViewPDFTest.USER_NAME, ViewPDFTest.fontUserName));
            Assert.Equal("Parameter cannot be null\r\nParameter name: numberColumns", ex.Message);
            Assert.Equal("numberColumns", ex.ParamName);
        }

        [Fact]
        public void setFirstLineTest()
        {
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator("setFirstLineTest");
            List<Column> columns = ViewPDFTest.getColumns();
            columns.RemoveAt(0);
            pDFFormatTableGenerator.setNumberColumns(ViewPDFTest.NUMBERS_COLUMNS);
            pDFFormatTableGenerator.setNameUser(ViewPDFTest.USER_NAME, ViewPDFTest.fontUserName);
            Exception ex = Assert.Throws<Exception>(() => pDFFormatTableGenerator.setFirstLine(columns));
            Assert.Equal("numberColumns different columns.Count", ex.Message);
        }
    }
}
