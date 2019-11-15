using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace KPO_laba10
{
    public static class PrepareGeneration
    {
        public static TableIdentifier TableIdentifier;
        public static Error Error;
        public static Triads createTriads()
        {
            return new Triads();
        }
        public static DSR createDSR()
        {
            return new DSR();
        }
        public static void beginGeneration()
        {
            DSR dsr = createDSR();
            Triads triads = createTriads();
            GenerationCode.dsR = dsr;
            GenerationCode.triads = triads;
            GenerationCode.generate();
        }
    }
}