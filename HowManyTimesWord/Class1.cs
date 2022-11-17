using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimesWord
{
    public class Class1
    {
        public static int WordCount(string textString, string word)
        {
            int count = 0;
           var text = textString.Split(' ');
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == word)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
