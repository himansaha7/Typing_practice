using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace Typing_Practice
{
    partial class SettingDialog
    {
        public List<string> charactersWithoutShift = new List<string>(new string [] {"`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=",
            "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", @"\", "a", "s", "d", "f", "g", "h", "j",
            "k", "l", ";", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "/" });

        public List<string> charactersWithShift = new List<string>(new string[] {"~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+",
            "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "{", "}", "|", "A", "S", "D", "F", "G", "H", "J",
            "K", "L", ":", "\"", "Z", "X", "C", "V", "B", "N", "M", "<", ">", "?" });

        public List<Button> buttons = new List<Button>();

        private void initializeCustomComponent()
        {

            //initializing key buttons------------------------------------------------------------------
            int i = 0;
            for (; i <= 12; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(70 + 55 * i, 110);
                btn.Text = charactersWithoutShift[i];
                buttons.Add(btn);
            }

            for (; i <= 25; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(70 + 80 + 55 * (i - 13), 175);
                btn.Text = charactersWithoutShift[i];
                buttons.Add(btn);
            }

            for (; i <= 36; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(70 + 95 + 55 * (i - 26), 240);
                btn.Text = charactersWithoutShift[i];
                buttons.Add(btn);
            }

            for (; i <= 46; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(70 + 110 + 55 * (i - 37), 305);
                btn.Text = charactersWithoutShift[i];
                buttons.Add(btn);
            }

            foreach (var btn in buttons)
            {
                btn.Size = new Size(50, 50);
                btn.Font = new Font("calibri", 12f);
                btn.BackColor = Color.White;
                btn.UseMnemonic = false;     //to set "&" as text to button
                btn.Visible = true;
                btn.BringToFront();
                this.Controls.Add(btn);
                btn.Click += new EventHandler(keyBtnClick);
            }


            //intitializing favourite box---------------------------------------------------------------
            if (!Directory.Exists(directoryFavourites))
            {
                Directory.CreateDirectory(directoryFavourites);
            }

            favourite_box.Items.Add("setting");

            DirectoryInfo d = new DirectoryInfo(directoryFavourites);

            foreach (var file in d.GetFiles("*.json"))
            {
                favourite_box.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

    }
}
