using System;
using System.Collections.Generic;
using System.Text;

namespace TpModul4
{
    internal class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Samoja, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer
        }

        public static string GetKodePos(Kelurahan kelurahan)
        {
            string[] kodePos = {
                "40266", "40287", "40267", "40256", "40287", "40273", "40286", "40286", "40286", "40272", "40274"
            };

            return kodePos[(int)kelurahan];
        }
    }
}
