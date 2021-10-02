using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Practice
{
    public partial class TestResultDialog : Form
    {
        private int speed;
        private double accuracy;
        private int correctEntries;
        private int incorrectEntries;
        private int totalEntries;
        private int totalTime;

        public TestResultDialog(int speed, double accuracy, int correctEntries, int incorrectEntries, int totalTime)
        {
            InitializeComponent();

            this.speed = speed;
            this.accuracy = accuracy;
            this.correctEntries = correctEntries;
            this.incorrectEntries = incorrectEntries;
            this.totalEntries = correctEntries + incorrectEntries;
            this.totalTime = totalTime;
        }

        private void TestResultDialog_Load(object sender, EventArgs e)
        {
            speedLabel.Text = speed.ToString() + " WPM";
            accuracyLabel.Text = String.Format("{0:0.0}", accuracy) + " %";
            correctEntriesLabel.Text = correctEntries.ToString();
            incorrectEntriesLabel.Text = incorrectEntries.ToString();
            totalEntriesLabel.Text = totalEntries.ToString();
            totalTimeLabel.Text = totalTime.ToString() + " min";

            speedBarGraph.Size = new Size(speedBarGraph.Size.Width, speed * 2);
            speedBarGraph.Location = new Point(speedBarGraph.Location.X, groundLevelBar.Location.Y - speedBarGraph.Size.Height);
        }
    }
}