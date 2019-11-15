using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public static class Lexser
    {
        public static TableIdentifier TableIdentifier;
        public static TabelLexsems TabelLexsems;
        public static Error Error;
        public static void LexAnalysis(string textProgram)
        {
            Parser.Parsing();
        }
    }
}