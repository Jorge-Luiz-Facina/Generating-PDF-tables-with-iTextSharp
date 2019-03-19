namespace Generating_PDF_with_iTextSharp
{
    class Score
    {
        public const string LEVEL = "Level";
        public const string TIME = "Time";
        public const string CORRECT_PLANE = "Correct Plane";
        public const string NEUTRAL_PLANE = "Neutral Plane";
        public const string BAD_PLANE = "Bad Plane";
        public const string TERRIBLE_PLANE = "Terrible Plane";


        private string level;
        private string time;
        private string correctPlane;
        private string neutralPlane;
        private string badPlane;
        private string terriblePlane;

        public Score setLevel(string level)
        {
            this.level = level;
            return this;
        }

        public Score setTime(string time)
        {
            this.time = time;
            return this;
        }

        public Score setCorrectPlane(string correctPlane)
        {
            this.correctPlane = correctPlane;
            return this;
        }

        public Score setNeutralPlane(string neutralPlane)
        {
            this.neutralPlane = neutralPlane;
            return this;
        }

        public Score setBadPlane(string badPlane)
        {
            this.badPlane = badPlane;
            return this;
        }

        public Score setTerriblePlane(string terriblePlane)
        {
            this.terriblePlane = terriblePlane;
            return this;
        }

        public string getLevel()
        {
            return level;
        }

        public string getTime()
        {
            return time;
        }

        public string getCorrectPlane()
        {
            return correctPlane;
        }

        public string getNeutralPlane()
        {
            return neutralPlane;
        }

        public string getBadPlane()
        {
            return badPlane;
        }

        public string getTerriblePlane()
        {
            return terriblePlane;
        }
    }
}
