using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class BCoder : ICoder
    {
        readonly int key;
        public BCoder(int k)
        {
            key = k;
        }

        public string Encode(string enc)
        {
            string encodeText = ""; 
            for (int i = 0; i < enc.Length; i++)
            {
                int n = enc[i] ^ key;
                encodeText = encodeText + (char)n;
            }

            return encodeText;
        }

        public string Decode(string dec)
        {
            string decodeText = ""; 
            for (int i = 0; i < dec.Length; i++)
                decodeText += (char)(dec[i] ^ key);
            return decodeText;
        }

        
    }
}
