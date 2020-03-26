using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightsLibrary
{
    public class TestWeights : ITests
    {
        #region Fields
        private static TestWeights instance;
        private static object syncLock = new object();
        #endregion


        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private TestWeights(){}
        #endregion

        #region Properties
        public static TestWeights Instance { get { if (instance == null) { lock (syncLock) { if (instance == null) { instance = new TestWeights(); } } } return instance; }  }
        public float TermTest1 { get; set; } = 0.3f;
        public float TermTest2 { get; set; } = 0.3f;
        public float AdditionalTests { get; set; } = 0.1f;
        public float Practicals { get; set; } = 0.1f;
        public float Project { get; set; } = 0.2f;
        public float Exam { get; set; } = 1f;
        public float Predicate { get; set; } = 1f;
        #endregion
    }
}
