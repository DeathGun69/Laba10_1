using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            OriginalProgram originalProg = new OriginalProgram(@"kode");
            Reader.StartAnalysis(originalProg.FileProgram);            
        }
    }
}
