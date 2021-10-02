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
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Typing_Practice
{
    public partial class MainForm : Form
    {
        //in this path we wills store settings.json file, this file will contain all the settings made by user
        private const string pathSettingJSON = "C:\\Random-Word-Typing-Practice\\setting.json";

        //maximum length of a word that will be generated randomly
        private const int maxWordLength = 8;
        //if n minutes time is selected then we will be generatting (n * 100) random words at once to display
        private const int targetWPM = 100;

        //will be used to resize all the components of the form
        private float mainFormPreviousWidth;
        private float mainFormPreviousHeight;

        //will be used to keep track of remaining times for the current typing test
        private int allocatedMin;
        private int remainingMin;
        private int remainingSec;

        public MainForm()
        {
            InitializeComponent();

            mainFormPreviousWidth = this.Size.Width;
            mainFormPreviousHeight = this.Size.Height;

            allocatedMin = 0;
            remainingMin = 0;
            remainingSec = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1000, 599);

            //if settings.json file does not exist in the expected path then we are creating this 
            if (File.Exists(pathSettingJSON) == false)
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Typing_Practice.Resources.setupFiles.settings.json");
                Directory.CreateDirectory(Path.GetDirectoryName(pathSettingJSON));
                FileStream fileStream = File.Create(pathSettingJSON);

                stream.CopyTo(fileStream);
                fileStream.Close();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            textView.BorderStyle = BorderStyle.None;
            textWrite.BorderStyle = BorderStyle.None;

            Util.drawBoder(textView, Color.Black, 4, e.Graphics);
            Util.drawBoder(textWrite, Color.Black, 4, e.Graphics);
        }

        /*************************************** form size has changed *************************************/
        private void MainForm_Resize(object sender, EventArgs e)
        {          
            if(this.Size.Width >= this.MinimumSize.Width && this.Size.Height >= this.MinimumSize.Height)
            {
                float size1 = this.Size.Width / mainFormPreviousWidth;
                float size2 = this.Size.Height / mainFormPreviousHeight;

                SizeF scale = new SizeF(size1, size2);
                foreach (Control control in this.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2), FontStyle.Bold);
                    control.Scale(scale);
                }

                mainFormPreviousWidth = this.Size.Width;
                mainFormPreviousHeight = this.Size.Height;
            }            
        }

        /*************************************** start button click ****************************************/
        private void StartButton_Click(object sender, EventArgs e)
        {            
            if (selectDurationChoice.Items.Contains(selectDurationChoice.Text))
            {
                remainingMin = int.Parse(selectDurationChoice.Text.Split(' ')[0]);
                remainingSec = 0;
                allocatedMin = remainingMin;

                remainingTimeLabel.Text = Util.convertToTimeString(remainingMin, remainingSec);

                //reading settings.json file from specified directory and extracting character selected by user
                var settingJSON = File.ReadAllText(pathSettingJSON);
                var jobject = JObject.Parse(settingJSON);
                string[] selectedChar = jobject["choosedChars"].ToObject<string[]>();

                textView.Text = Util.generateRandomText(selectedChar, remainingMin * targetWPM, maxWordLength);
                textView.Select(0, 1);

                textWrite.Clear();
                /*in the tag we are storing how many char was there earlier, this will be usefull to detect
                whether a char has been added or removed from the textBox */
                textWrite.Tag = 0;
                textWrite.Focus();

                timer.Stop();
            }
        }

        /**************************************** 1 seconds is over ***************************************/
        private void Timer_Tick(object sender, EventArgs e)
        {                
            if (remainingSec == 0)
            {
                if (remainingMin == 0)
                {
                    timer.Stop();

                    //showing analysis of current typing result to user
                    int totalEntries = textWrite.TextLength;
                    int incorrectEntries = Util.totalNoOfMismatchChars(textView.Text, textWrite.Text);
                    int correctEntries = totalEntries - incorrectEntries;
                    int speed = correctEntries / 5 / allocatedMin;
                    double accuracy = Convert.ToDouble(correctEntries) / Convert.ToDouble(totalEntries) * 100.0;
                    new TestResultDialog(speed, accuracy, correctEntries, incorrectEntries, allocatedMin).ShowDialog();
                    
                    //----------------need to save the typing speed in a file for future analysis ------------------

                    //resetting variables and views
                    allocatedMin = 0;
                    textView.Clear();
                    textWrite.Clear();                                      
                }
                else
                {
                    remainingMin -= 1;
                    remainingSec = 59;
                }

            }         
            else remainingSec -= 1;

            remainingTimeLabel.Text = Util.convertToTimeString(remainingMin, remainingSec);
        }

        /**************** some char has been added or removed from the textWrite textbox ***************/
        private void TextWrite_TextChanged(object sender, EventArgs e)
        {
            if (remainingMin == 0 && remainingSec == 0) return;

            // first character has been pressed after resetting the time, so starting the timer
            if (timer.Enabled == false && (remainingMin > 0 || remainingSec > 0)) timer.Start();

            //if a char has been added to the textWrite textBox
            if(textWrite.TextLength > (int)textWrite.Tag)
            {
                if (textWrite.Text.ElementAt<char>(textWrite.TextLength - 1) != textView.SelectedText.ElementAt<char>(0))
                {
                    textView.SelectionColor = Color.Red;
                    if (textView.SelectedText.ElementAt<char>(0) == ' ')
                    {
                        textView.SelectedText = "_";
                    }
                }
                else textView.SelectionColor = Color.Gray;

                textWrite.Tag = textWrite.TextLength;
                textView.Select(textWrite.Text.Length, 1);
            }
            //if a char has been deleted from the textWrite textBox
            else
            {
                textWrite.Tag = textWrite.TextLength;

                textView.Select(textWrite.Text.Length, 1);
                textView.SelectionColor = Color.Black;
                if (textView.SelectedText.ElementAt<char>(0) == '_')
                {
                    textView.SelectedText = " ";
                }

                textView.Select(textWrite.Text.Length, 1);
            }            
        }

        private void settingButtonLabel_Click(object sender, EventArgs e)
        {
            SettingDialog settingForm = new SettingDialog();
            settingForm.ShowDialog();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingDialog settingForm = new SettingDialog();
            settingForm.ShowDialog();
        }
    }
}
