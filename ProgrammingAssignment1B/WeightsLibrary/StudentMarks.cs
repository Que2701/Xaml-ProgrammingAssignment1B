using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightsLibrary
{
    public sealed class StudentMarks : TestBase, ITests
    {
        #region Fields
        private static StudentMarks instance;
        private static object syncRoot = new object();
        #endregion

        #region Constructor
        private StudentMarks() { }
        #endregion

        #region Properties
        public static StudentMarks Instance { get { if (instance == null) { lock (syncRoot) { if (instance == null) { instance = new StudentMarks(); } } } return instance; } }
        public float TermTest1 { get { return termTest1; } set { termTest1 = value; } }
        public float TermTest2 { get { return termTest2;  } set { termTest2 = value; } }
        public float AdditionalTests { get { return additionalTests;  } set { additionalTests = value; } }
        public float Practicals { get { return practicals; } set { practicals = value; } }
        public float Project { get { return project; } set { project = value; } }
        public float Exam { get { return exam; } set { exam = value; } }
        public float Predicate { get { return predicate; } set { predicate = value; } }
        #endregion
    }
}
