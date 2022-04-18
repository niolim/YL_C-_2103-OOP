using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class ACoder : ICoder
    {
        public string Encode(string enc)
        {
            string encodeText = "";
            for (int i = 0; i < enc.Length; i++)
            {
                int n = enc[i] + 1;
                encodeText = encodeText + (char)n;
            }
            return encodeText;
        }

        public string Decode(string dec)
        {
            string decodeText = "";
            for (int i = 0; i < dec.Length; i++)
            {
                int n = dec[i] - 1;
                decodeText = decodeText + (char)n;
            }
            return decodeText;
        }




    }
}
