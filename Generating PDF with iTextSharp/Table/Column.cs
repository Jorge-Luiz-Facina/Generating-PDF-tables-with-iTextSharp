using iTextSharp.text;

namespace Generating_PDF_with_iTextSharp
{
    class Column
    {
        public string name;
        public Font font;

        public Column(string name, Font font)
        {
            this.name = name;
            this.font = font;
        }
        
    }
}
