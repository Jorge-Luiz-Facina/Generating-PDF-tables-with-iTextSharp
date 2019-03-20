using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using Generating_PDF_with_iTextSharp.ScoreTable;

namespace Generating_PDF_with_iTextSharp.Table
{
    public class PDFFormatTableGenerator
    {
        public const string ARCHIVE_NAME = "score";
        private Document document;
        private PdfWriter writer;
        private PdfPTable table;
        private int numberColumns;

        public PDFFormatTableGenerator()
        {
            document = new Document(PageSize.A4);
            document.SetMargins(3, 2, 3, 2);
            writer = PdfWriter.GetInstance(document, new FileStream(Directory.GetCurrentDirectory() + "\\" + ARCHIVE_NAME + ".pdf", FileMode.Create));
            document.Open();
        }

        public PDFFormatTableGenerator(string archiveName)
        {
            document = new Document(PageSize.A4);
            document.SetMargins(3, 2, 3, 2);
            writer = PdfWriter.GetInstance(document, new FileStream(Directory.GetCurrentDirectory() + "\\" + archiveName + ".pdf", FileMode.Create));
            document.Open();
        }

        public void setMargins(float marginLeft, float marginRight, float marginTop, float marginBottom)
        {
            document.SetMargins(marginLeft, marginRight, marginTop, marginBottom);
        }

        public void setNameArchivePDF(string name)
        {
            writer = PdfWriter.GetInstance(document, new FileStream(Directory.GetCurrentDirectory() +"\\" + name + ".pdf", FileMode.Create));
        }

        public void setNumberColumns(int size)
        {
            numberColumns = size;
            table = new PdfPTable(numberColumns);
        }

        public void setNameUser(string name, Font font)
        {
            if(numberColumns.Equals(0))
                throw new System.ArgumentException("Parameter cannot be null", "numberColumns");
            PdfPCell cell = setPdfPCellAlignmentCenter(new Phrase(name, font));
            cell.Colspan = numberColumns;
            table.AddCell(cell);
        }

        public void setFirstLine(List<Column> columns)
        {
            if (!numberColumns.Equals(columns.Count))
                throw new System.Exception("numberColumns different columns.Count");
            foreach (Column column in columns)
            {
                Paragraph newColumn = new Paragraph(column.name, column.font);
                PdfPCell newCell = setPdfPCellAlignmentCenter(newColumn);
                table.AddCell(newCell);
            }
        }

        public void setScoreTable(List<Score> scores, Font font)
        {
            foreach (Score score in scores)
            {
                addCell(score.getLevel(), font);
                addCell(score.getTime(), font);
                addCell(score.getCorrectPlane(), font);
                addCell(score.getNeutralPlane(), font);
                addCell(score.getBadPlane(), font);
                addCell(score.getTerriblePlane(), font);
            }
        }

        public void generateTable()
        {
            document.Add(table);
            document.Close();
        }

        private void addCell(string information, Font font)
        {
            Phrase newColumn = new Phrase(information, font);
            PdfPCell cell = setPdfPCellAlignmentCenter(newColumn);
            table.AddCell(cell);
        }

        private PdfPCell setPdfPCellAlignmentCenter(Phrase phrase)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_CENTER;
            return cell;
        } 
    }
}
