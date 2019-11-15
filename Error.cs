using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public class Error
    {
        public List<int> errorList {get; set;}
        public void addError(int Error)
        {
            errorList.Add(Error);
        }
    }    
}