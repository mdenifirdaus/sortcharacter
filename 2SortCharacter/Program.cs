using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SortCharacter
{
    class Program
    {
        const string VOWEL_CHAR = "aiueo";
        const string CONSONANT_CHAR = "bcdfghjklmnpqrstvwxyz";

        static void Main(string[] args)
        {
            //parameter mKey
            //V: Vowel
            //C: Consonant
            FindSortCharacters("C", "CABAHMU");
        }

        public static void FindSortCharacters(string mKey, string mInput)
        {
            var mStrBuild = new StringBuilder();
            if (mKey == "V")
            {
                for (int i = 0; i < mInput.Length; i++)
                {
                    string charInput = mInput[i].ToString().ToLower();
                    if (VOWEL_CHAR.Contains(charInput))
                    {
                        mStrBuild.Append(charInput);
                    }
                }
            }
            else if (mKey == "C")
            {
                for (int i = 0; i < mInput.Length; i++)
                {
                    string charInput = mInput[i].ToString().ToLower();
                    if (CONSONANT_CHAR.Contains(charInput))
                    {
                        mStrBuild.Append(charInput);
                    }
                }
            }
            else
                mStrBuild.Append("Command not correct!");

            //print and sort text
            char[] mStr = mStrBuild.ToString().ToCharArray();
            Array.Sort<char>(mStr);

            var sorted = "";
            for (int i = 0; i < mStr.Length; i++)
            {
                sorted += mStr[i];
            }

            Console.WriteLine(sorted);
        }
    }
}
