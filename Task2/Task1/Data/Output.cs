using System;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlRoot]
    public class Output
    {
        public decimal SumResult { get; set; }
        public int MulResult { get; set; }
        public decimal[] SortedInputs { get; set; }
    }
}
