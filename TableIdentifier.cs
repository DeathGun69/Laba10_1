using System;
using System.IO;
using System.Text;
using System.Collections;

namespace KPO_laba10
{
    public class TableIdentifier
    {
        public Hashtable IdentifierList{ get; set; }
        public void addIdentifier(string Iden, int code)
        {
            IdentifierList.Add(code, Iden);
        }
    }
}