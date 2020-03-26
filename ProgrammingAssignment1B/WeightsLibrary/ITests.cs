using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightsLibrary
{
    public interface ITests 
    {
        float TermTest1 { get; set; }
        float TermTest2 { get; set; }
        float AdditionalTests { get; set; }
        float Practicals { get; set; }
        float Project { get; set; }
        float Exam { get; set; }
        float Predicate { get; set; }
    }
}
