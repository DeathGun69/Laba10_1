using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public static class SemanticAnalizer
    {
        public static TableIdentifier TableIdentifier;
        public static Error Error;
        public static void SemanticAnalysis()
        {
            PrepareGeneration.beginGeneration();
        }
    }
}