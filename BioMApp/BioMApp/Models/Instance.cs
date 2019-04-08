using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMApp.Models
{
    public static class Instance
    {
        public static int index=-1;
        public static int answer;

        public static int PosAnsS = 0;
        public static int NegAnsS = 0;

        public static int PosAnsRM = 0;
        public static int NegAnsRM = 0;

        public static int PosAnsHM = 0;
        public static int NegAnsHM = 0;

        public static List<TimeSpan> timeIntervalSilence = new List<TimeSpan>();
        public static List<TimeSpan> timeIntervalRelaxMusic = new List<TimeSpan>();
        public static List<TimeSpan> timeIntervalHardMusic = new List<TimeSpan>();



        public static void Reset()
        {

         index = -1;
        
         PosAnsS = 0;
         NegAnsS = 0;

         PosAnsRM = 0;
         NegAnsRM = 0;

         PosAnsHM = 0;
         NegAnsHM = 0;

         timeIntervalSilence = new List<TimeSpan>();
         timeIntervalRelaxMusic = new List<TimeSpan>();
         timeIntervalHardMusic = new List<TimeSpan>();



    }

    }
}
