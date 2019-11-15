using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public static class Parser
    {
        public static TableIdentifier TableIdentifier;
        public static Error Error;
        public static void Parsing()
        {
            SemanticAnalizer.TableIdentifier = TableIdentifier;
            SemanticAnalizer.Error = Error;
            SemanticAnalizer.SemanticAnalysis();
        }
    }
}