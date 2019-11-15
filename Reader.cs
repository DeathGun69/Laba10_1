using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
        public class Reader
        {
            public static string ReadFile(FileStream FileProgram) {  
            return " ";
            }
            public static void StartAnalysis(FileStream fileStr) {   
                ReadFile(fileStr);
                Lexser.TableIdentifier = new TableIdentifier();
                Lexser.Error = new Error();
                Lexser.LexAnalysis("kode");
            }
        }
}