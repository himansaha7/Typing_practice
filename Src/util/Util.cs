using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Typing_Practice
{
    public class Util
    {
        //will be used to generate random word
        private static Random randomNumberGenerator = new Random();

        /* given some selected chars, maximum length of a word, this method will generate a random text having
         'totoalWord' no. of word and returns that text */
        public static string generateRandomText(string[] selectedChar, int totalWord, int maxLengthOfWord)
        {
            string text = "";
            for (int i = 0; i < totalWord; i++)
            {
                text += generateRandomWord(selectedChar, maxLengthOfWord);
                text += " ";
            }

            return text;
        }

        /* given selected chars and maximum length of a word, this method will generate a random word and
          returns that word */
        public static string generateRandomWord(string[] selectedChar, int maxLengthOfWord)
        {
            int length = randomNumberGenerator.Next(1, maxLengthOfWord);

            string word = "";
            for (int i = 0; i < length; i++)
            {
                int charPosition = randomNumberGenerator.Next(0, selectedChar.Length);
                word += selectedChar[charPosition];
            }

            return word;
        }

        /* given min and sec this method will return a string in the format given below -
         if min:5 sec:2, then "05 : 02" will be returned. if min:10 sec:20, then "10 : 20" will be returned */
        public static string convertToTimeString(int min, int sec)
        {
            string time = "";

            if (min < 10) time += "0";
            time += min.ToString();

            time += " : ";

            if (sec < 10) time += "0";
            time += sec.ToString();

            return time;
        }

        /* given two string 'matchWith' and 'str', this method will return total no. of mismatched character between this two string */
        public static int totalNoOfMismatchChars(string matchWith, string str)
        {
            int totalMismatch = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (matchWith.ElementAt<char>(i) != str.ElementAt<char>(i)) totalMismatch++;
            }

            return totalMismatch;
        }

        /* draw a broder around the control */
        public static void drawBoder(Control control, Color color, int width, Graphics graphics)
        {
            Pen pen = new Pen(new SolidBrush(color), width);
            graphics.DrawRectangle(pen, new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
        }
    }
}
