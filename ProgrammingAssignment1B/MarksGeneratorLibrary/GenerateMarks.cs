using System;
using WeightsLibrary;

namespace MarksGeneratorLibrary
{
    public class GenerateMarks
    {
        #region Fields
        private static GenerateMarks instance;
        private static object syncRoot = new object();
        private StudentMarks studentMarks = StudentMarks.Instance;
        private Random random = new Random();
        #endregion

        #region Constructor
        private GenerateMarks(){}
        #endregion

        #region Properties
        public static GenerateMarks Instance { get { if (instance == null) { lock (syncRoot) { if (instance == null) { instance = new GenerateMarks(); } } } return instance; } }
        #endregion

        #region Methods
        public bool GoodMarks()
        {
            int minValue = 50;
            int maxValue = 100;

            studentMarks.Practicals = (float)random.Next(minValue, maxValue);
            studentMarks.TermTest1 = (float)random.Next(minValue, maxValue);
            studentMarks.TermTest2 = (float)random.Next(minValue, maxValue);
            studentMarks.AdditionalTests = (float)random.Next(minValue, maxValue);
            studentMarks.Project = (float)random.Next(minValue, maxValue);
            return true;
        }

        public bool BadMarks()
        {
            int minValue = 20;
            int maxValue = 50;

            studentMarks.Practicals = (float)random.Next(minValue, maxValue);
            studentMarks.TermTest1 = (float)random.Next(minValue, maxValue);
            studentMarks.TermTest2 = (float)random.Next(minValue, maxValue);
            studentMarks.AdditionalTests = (float)random.Next(minValue, maxValue);
            studentMarks.Project = (float)random.Next(minValue, maxValue);
            return true;
        }
        #endregion

    }
}
