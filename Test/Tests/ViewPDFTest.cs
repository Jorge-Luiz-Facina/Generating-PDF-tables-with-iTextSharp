using Xunit;
using Generating_PDF_with_iTextSharp.Table;
using Generating_PDF_with_iTextSharp.ScoreTable;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;

namespace Test.Tests
{
    public class ViewPDFTest
    {
        public static Font fontUserName = new Font(FontFactory.GetFont("Arial", 20, Font.BOLD));
        public static Font fontFirstLine = new Font(FontFactory.GetFont("Arial", 16, Font.BOLD));
        public static Font font = new Font(FontFactory.GetFont("Arial", 10, Font.BOLD));

        public const string USER_NAME = "Main Duelo";
        public const int NUMBERS_COLUMNS = 6;

        [Fact]
        public void viewPDFWith3ScoresTest()
        {
            string fileName = "viewPDFWith3Scores";
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator(fileName);
            List<Column> columns = getColumns();
            List<Score> scores = get3Scores();
            pDFFormatTableGenerator.setNumberColumns(NUMBERS_COLUMNS);
            pDFFormatTableGenerator.setNameUser(USER_NAME, fontUserName);
            pDFFormatTableGenerator.setFirstLine(columns);
            pDFFormatTableGenerator.setScoreTable(scores, font);
            pDFFormatTableGenerator.generateTable();
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\" + fileName + ".pdf");
        }

        [Fact]
        public void viewPDFWith10ScoresTest()
        {
            string fileName = "viewPDFWith10Scores";
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator(fileName);
            List<Column> columns = getColumns();
            List<Score> scores = get10Scores();
            pDFFormatTableGenerator.setNumberColumns(NUMBERS_COLUMNS);
            pDFFormatTableGenerator.setNameUser(USER_NAME, fontUserName);
            pDFFormatTableGenerator.setFirstLine(columns);
            pDFFormatTableGenerator.setScoreTable(scores, font);
            pDFFormatTableGenerator.generateTable();
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\" + fileName + ".pdf");
        }

        [Fact]
        public void viewPDFWith50ScoresTest()
        {
            string fileName = "viewPDFWith50Scores";
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator(fileName);
            List<Column> columns = getColumns();
            List<Score> scores = get50Scores();
            pDFFormatTableGenerator.setNumberColumns(NUMBERS_COLUMNS);
            pDFFormatTableGenerator.setNameUser(USER_NAME, fontUserName);
            pDFFormatTableGenerator.setFirstLine(columns);
            pDFFormatTableGenerator.setScoreTable(scores, font);
            pDFFormatTableGenerator.generateTable();
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\" + fileName + ".pdf");
        }

        [Fact]
        public void viewPDFWith100ScoresTest()
        {
            string fileName = "viewPDFWith100Scores";
            PDFFormatTableGenerator pDFFormatTableGenerator = new PDFFormatTableGenerator(fileName);
            List<Column> columns = getColumns();
            List<Score> scores = get100Scores();
            pDFFormatTableGenerator.setNumberColumns(NUMBERS_COLUMNS);
            pDFFormatTableGenerator.setNameUser(USER_NAME, fontUserName);
            pDFFormatTableGenerator.setFirstLine(columns);
            pDFFormatTableGenerator.setScoreTable(scores, font);
            pDFFormatTableGenerator.generateTable();
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\" + fileName + ".pdf");
        }

        public static List<Score> get3Scores()
        {
            List<Score> scores = new List<Score>();

            Score score01 = new Score()
                .setLevel("1")
                .setTime("59")
                .setCorrectPlane("32")
                .setNeutralPlane("22")
                .setBadPlane("12")
                .setTerriblePlane("22");

            Score score02 = new Score()
                .setLevel("2")
                .setTime("01:22")
                .setCorrectPlane("54")
                .setNeutralPlane("11")
                .setBadPlane("4")
                .setTerriblePlane("0");

            Score score03 = new Score()
                .setLevel("3")
                .setTime("34:77")
                .setCorrectPlane("89")
                .setNeutralPlane("47")
                .setBadPlane("44")
                .setTerriblePlane("36");

            scores.Add(score01);
            scores.Add(score02);
            scores.Add(score03);

            return scores;
        }

        public static List<Score> get10Scores()
        {
            List<Score> scores = new List<Score>();

            Score score01 = new Score()
                .setLevel("1")
                .setTime("59")
                .setCorrectPlane("32")
                .setNeutralPlane("22")
                .setBadPlane("12")
                .setTerriblePlane("22");

            Score score02 = new Score()
                .setLevel("2")
                .setTime("01:22")
                .setCorrectPlane("54")
                .setNeutralPlane("11")
                .setBadPlane("4")
                .setTerriblePlane("0");

            Score score03 = new Score()
                .setLevel("3")
                .setTime("34:77")
                .setCorrectPlane("89")
                .setNeutralPlane("47")
                .setBadPlane("44")
                .setTerriblePlane("36");

            Score score04 = new Score()
                .setLevel("4")
                .setTime("99:37")
                .setCorrectPlane("21")
                .setNeutralPlane("90")
                .setBadPlane("333")
                .setTerriblePlane("67");

            Score score05 = new Score()
                .setLevel("5")
                .setTime("00:77")
                .setCorrectPlane("12")
                .setNeutralPlane("76")
                .setBadPlane("009")
                .setTerriblePlane("334");

            Score score06 = new Score()
                .setLevel("6")
                .setTime("104")
                .setCorrectPlane("321")
                .setNeutralPlane("44")
                .setBadPlane("55")
                .setTerriblePlane("19");

            Score score07 = new Score()
                .setLevel("7")
                .setTime("17:32")
                .setCorrectPlane("41")
                .setNeutralPlane("76")
                .setBadPlane("90")
                .setTerriblePlane("54");

            Score score08 = new Score()
                .setLevel("8")
                .setTime("67:32")
                .setCorrectPlane("79")
                .setNeutralPlane("33")
                .setBadPlane("16")
                .setTerriblePlane("53");

            Score score09 = new Score()
                .setLevel("9")
                .setTime("48:44")
                .setCorrectPlane("56")
                .setNeutralPlane("83")
                .setBadPlane("33")
                .setTerriblePlane("12");

            Score score10 = new Score()
                .setLevel("10")
                .setTime("78:89")
                .setCorrectPlane("66")
                .setNeutralPlane("99")
                .setBadPlane("46")
                .setTerriblePlane("335");

            scores.Add(score01);
            scores.Add(score02);
            scores.Add(score03);
            scores.Add(score04);
            scores.Add(score05);
            scores.Add(score06);
            scores.Add(score07);
            scores.Add(score08);
            scores.Add(score09);
            scores.Add(score10);

            return scores;
        }

        public static List<Score> get50Scores()
        {
            List<Score> scores = new List<Score>();
            for(int i = 0; i < 50; i++)
            {
                scores.Add(new Score()
                .setLevel(i.ToString())
                .setTime(i.ToString())
                .setCorrectPlane(i.ToString())
                .setNeutralPlane(i.ToString())
                .setBadPlane(i.ToString())
                .setTerriblePlane(i.ToString()));
            }

            return scores;
        }

        public static List<Score> get100Scores()
        {
            List<Score> scores = new List<Score>();
            for (int i = 0; i < 100; i++)
            {
                scores.Add(new Score()
                .setLevel(i.ToString())
                .setTime(i.ToString())
                .setCorrectPlane(i.ToString())
                .setNeutralPlane(i.ToString())
                .setBadPlane(i.ToString())
                .setTerriblePlane(i.ToString()));
            }

            return scores;
        }

        public static List<Column> getColumns()
        {
            return new List<Column> { new Column(Score.LEVEL, fontFirstLine),
                new Column(Score.TIME, fontFirstLine),
                new Column(Score.CORRECT_PLANE, fontFirstLine),
                new Column(Score.NEUTRAL_PLANE, fontFirstLine),
                new Column(Score.BAD_PLANE, fontFirstLine),
                new Column(Score.TERRIBLE_PLANE, fontFirstLine) };
        }
    }
}
