using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewTask7
{
    public static class Extentions
    {
        public static int ExMethod(this string sentence,string word)
        {
            int result = 0;
            if ((sentence.IndexOf(word,0))!=-1)
            {
                result++;
            }
            return result;
        }
    }
}
