using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public class Triads
    {
        public List<string> TriadsList = new List<string>();
        public List<string> GetTriads()
        {
            return this.TriadsList;
        }
        public void SetTriads(List<string> TriadsList)
        {
            this.TriadsList = TriadsList;
        }
        public void addTriad(string Triad)
        {
            this.TriadsList.Add(Triad);
        }
    }
}