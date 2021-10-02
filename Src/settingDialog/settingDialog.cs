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
    public partial class SettingDialog : Form
    {
        public class settingJsonObject
        {
            public List<string> choosedChars;
            public settingJsonObject()
            {
                choosedChars = new List<string>();
            }
        }

        public const string directoryFavourites = "C:\\Random-Word-Typing-Practice\\Favourites";
        public const string pathSetting = "C:\\Random-Word-Typing-Practice\\setting.json";

        public List<string> pressedCharacters = new List<string>();
        public SettingDialog()
        {
            InitializeComponent();
            initializeCustomComponent();
        }

        

        private void keyBtnClick(object sender, EventArgs e)
        {
            Button clicked_button = (Button)sender;
            if (pressedCharacters.Contains(clicked_button.Text))
            {
                pressedCharacters.Remove(clicked_button.Text);
                clicked_button.BackColor = Color.White;
                clicked_button.ForeColor = Color.Black;
            }
            else
            {
                pressedCharacters.Add(clicked_button.Text);
                clicked_button.BackColor = Color.Green;
                clicked_button.ForeColor = Color.White;
            }

            
            favourite_box.SelectedIndex = -1;
            favourite_box.Text = "Select Favourite";
        }

        
        private void setBtnClick(object sender, EventArgs e)
        {
            if (pressedCharacters.Count == 0)
            {
                MessageBox.Show("You are not supposed to practice with no characters", "No char", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(pathSetting))
                File.Delete(pathSetting);


            settingJsonObject tempFav = new settingJsonObject();
            tempFav.choosedChars = pressedCharacters;
            string jsonResult = JsonConvert.SerializeObject(tempFav);

            using (var tw = new StreamWriter(pathSetting, true))
            {
                tw.WriteLine(jsonResult.ToString());
                tw.Close();
            }

            labelSet.Visible = true;
            timer1.Tag = "Set";
            timer1.Start();
        }

        private void addFavBtnClick(object sender, EventArgs e)
        {
            if (pressedCharacters.Count == 0)
            {
                MessageBox.Show("There is no meaning of adding a favourite with empty characters", "Empty char", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(EnterFavTxtBox.Text))
            {
                MessageBox.Show("Enter valid favourite name", "Invalid favourite name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if the json file with the same name exist or not
            string path = directoryFavourites + "\\" + EnterFavTxtBox.Text + ".json";
            if (File.Exists(path) || EnterFavTxtBox.Text == "setting")
            {
                MessageBox.Show("There is a favourite with same name", "duplicate name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            settingJsonObject tempFav = new settingJsonObject();
            tempFav.choosedChars = pressedCharacters;
            string jsonResult = JsonConvert.SerializeObject(tempFav);

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(jsonResult.ToString());
                tw.Close();
            }

            favourite_box.Items.Add(EnterFavTxtBox.Text);

            EnterFavTxtBox.Text = "";
            MessageBox.Show("favourite successfully added", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void favBoxDropDownClosed(object sender, EventArgs e)
        {
            if (favourite_box.SelectedIndex == -1) return;

            string selectedSettingPath;
            if (!favourite_box.SelectedItem.Equals("setting"))
            {
                selectedSettingPath = directoryFavourites + "\\" + favourite_box.SelectedItem + ".json";
            }
            else
                selectedSettingPath = pathSetting;

            var settingJSON = File.ReadAllText(selectedSettingPath);
            var jobject = JObject.Parse(settingJSON);
            pressedCharacters = jobject["choosedChars"].ToObject<List<string>>();

            foreach (var btn in buttons)
            {
                if (pressedCharacters.Contains(btn.Text))
                {
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.ForeColor = Color.Black;
                    btn.BackColor = Color.White;
                }
                
            }

        }

        private void delFavBtnClick(object sender, EventArgs e)
        {
            if (favourite_box.SelectedIndex < 0)
            {
                MessageBox.Show("no item selected", "NIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (favourite_box.SelectedItem.Equals("setting"))
            {
                MessageBox.Show("Main setting file is delete protected", "MDP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string deletePath = directoryFavourites + "\\" + favourite_box.SelectedItem + ".json";
            File.Delete(deletePath);

            labelDSF.Text = "'" + favourite_box.SelectedItem + "'" + " deleted successfully";
            labelDSF.Visible = true;
            timer1.Tag = "DSF";
            timer1.Start();


            favourite_box.Items.Remove(favourite_box.SelectedItem);
            if (favourite_box.SelectedIndex == -1) favourite_box.Text = "Select Favourite";
            
        }

        private void shiftClick(object sender, EventArgs e)
        {
            if (shiftButton.BackColor == Color.Green)
            {
                int i = 0;
                foreach (var btn in buttons)
                {
                    if(pressedCharacters.Contains(charactersWithoutShift[i]))
                    {
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Green;
                        btn.Text = charactersWithoutShift[i];
                    }
                    else
                    {
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;
                        btn.Text = charactersWithoutShift[i];
                    }
                    i++;
                }
                shiftButton.BackColor = Color.White;
                shiftButton.ForeColor = Color.Black;
            }
            else
            {
                int i = 0;
                foreach (var btn in buttons)
                {
                    if (pressedCharacters.Contains(charactersWithShift[i]))
                    {
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Green;
                        btn.Text = charactersWithShift[i];
                    }
                    else
                    {
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;
                        btn.Text = charactersWithShift[i];
                    }
                    i++;
                }
                shiftButton.BackColor = Color.Green;
                shiftButton.ForeColor = Color.White;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Tag.ToString() == "Set")
            {
                labelSet.Visible = false;
            }
            else
            {
                labelDSF.Visible = false;
            }
            timer1.Stop();
        }

        private void EnterFavTxtBox_click(object sender, EventArgs e)
        {
            EnterFavTxtBox.Text = "";
        }
    }
}
