using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public class DSR
    {
        public List<string> DSRList = new List<string>();
        public List<string> GetDSR()
        {
            return this.DSRList;
        }
        public void SetDSR(List<string> DSRList)
        {
            this.DSRList = DSRList;
        }
        public void addTriad(string Triad)
        {
            this.DSRList.Add(Triad);
        }
    }
}