﻿using System;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Input
    {
        public int K { get; set; }
        public decimal[] Sums { get; set; }
        public int[] Muls { get; set; }
    }
}
