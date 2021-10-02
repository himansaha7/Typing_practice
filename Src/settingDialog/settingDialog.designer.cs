
namespace Typing_Practice
{
    partial class SettingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingDialog));
            this.del_fav_btn = new System.Windows.Forms.Button();
            this.set_btn = new System.Windows.Forms.Button();
            this.add_fav_btn = new System.Windows.Forms.Button();
            this.favourite_box = new System.Windows.Forms.ComboBox();
            this.shiftButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDSF = new System.Windows.Forms.Label();
            this.labelSet = new System.Windows.Forms.Label();
            this.EnterFavTxtBox = new System.Windows.Forms.TextBox();
            this.EnterFavLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // del_fav_btn
            // 
            this.del_fav_btn.BackColor = System.Drawing.Color.Red;
            this.del_fav_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_fav_btn.ForeColor = System.Drawing.Color.White;
            this.del_fav_btn.Location = new System.Drawing.Point(387, 22);
            this.del_fav_btn.Name = "del_fav_btn";
            this.del_fav_btn.Size = new System.Drawing.Size(146, 55);
            this.del_fav_btn.TabIndex = 1;
            this.del_fav_btn.Text = "DELETE SELECTED FAVOURITE";
            this.toolTip1.SetToolTip(this.del_fav_btn, "ComboBox selected item will be deleted");
            this.del_fav_btn.UseVisualStyleBackColor = false;
            this.del_fav_btn.Click += new System.EventHandler(this.delFavBtnClick);
            // 
            // set_btn
            // 
            this.set_btn.BackColor = System.Drawing.Color.Yellow;
            this.set_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_btn.Location = new System.Drawing.Point(115, 411);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(84, 46);
            this.set_btn.TabIndex = 2;
            this.set_btn.Text = "SET";
            this.toolTip1.SetToolTip(this.set_btn, "Only greenBackcolored keys will be stored as current setting");
            this.set_btn.UseVisualStyleBackColor = false;
            this.set_btn.Click += new System.EventHandler(this.setBtnClick);
            // 
            // add_fav_btn
            // 
            this.add_fav_btn.BackColor = System.Drawing.Color.Lime;
            this.add_fav_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_fav_btn.ForeColor = System.Drawing.Color.Black;
            this.add_fav_btn.Location = new System.Drawing.Point(511, 411);
            this.add_fav_btn.Name = "add_fav_btn";
            this.add_fav_btn.Size = new System.Drawing.Size(146, 46);
            this.add_fav_btn.TabIndex = 3;
            this.add_fav_btn.Text = "ADD TO FAVOURITEs";
            this.toolTip1.SetToolTip(this.add_fav_btn, "Only greenBackcolored keys will be stored to favourite");
            this.add_fav_btn.UseVisualStyleBackColor = false;
            this.add_fav_btn.Click += new System.EventHandler(this.addFavBtnClick);
            // 
            // favourite_box
            // 
            this.favourite_box.BackColor = System.Drawing.Color.White;
            this.favourite_box.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favourite_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.favourite_box.FormattingEnabled = true;
            this.favourite_box.Location = new System.Drawing.Point(146, 41);
            this.favourite_box.Name = "favourite_box";
            this.favourite_box.Size = new System.Drawing.Size(157, 27);
            this.favourite_box.TabIndex = 4;
            this.favourite_box.Text = "Select Favourite";
            this.toolTip1.SetToolTip(this.favourite_box, "ComboBox to fetch currentSetting and favourites");
            this.favourite_box.DropDownClosed += new System.EventHandler(this.favBoxDropDownClosed);
            // 
            // shiftButton
            // 
            this.shiftButton.BackColor = System.Drawing.Color.White;
            this.shiftButton.Location = new System.Drawing.Point(70, 305);
            this.shiftButton.Name = "shiftButton";
            this.shiftButton.Size = new System.Drawing.Size(105, 50);
            this.shiftButton.TabIndex = 5;
            this.shiftButton.Text = "Shift";
            this.shiftButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.shiftButton, "click or unclick to see keys with or without shift");
            this.shiftButton.UseVisualStyleBackColor = false;
            this.shiftButton.Click += new System.EventHandler(this.shiftClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDSF
            // 
            this.labelDSF.AutoSize = true;
            this.labelDSF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSF.ForeColor = System.Drawing.Color.Green;
            this.labelDSF.Location = new System.Drawing.Point(555, 44);
            this.labelDSF.Name = "labelDSF";
            this.labelDSF.Size = new System.Drawing.Size(50, 19);
            this.labelDSF.TabIndex = 6;
            this.labelDSF.Text = "label1";
            this.labelDSF.Visible = false;
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSet.ForeColor = System.Drawing.Color.Green;
            this.labelSet.Location = new System.Drawing.Point(159, 460);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(80, 15);
            this.labelSet.TabIndex = 7;
            this.labelSet.Text = "set successful";
            this.labelSet.Visible = false;
            // 
            // EnterFavTxtBox
            // 
            this.EnterFavTxtBox.Location = new System.Drawing.Point(337, 437);
            this.EnterFavTxtBox.Name = "EnterFavTxtBox";
            this.EnterFavTxtBox.Size = new System.Drawing.Size(159, 20);
            this.EnterFavTxtBox.TabIndex = 8;
            this.EnterFavTxtBox.Click += new System.EventHandler(this.EnterFavTxtBox_click);
            // 
            // EnterFavLbl
            // 
            this.EnterFavLbl.AutoSize = true;
            this.EnterFavLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFavLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EnterFavLbl.Location = new System.Drawing.Point(338, 418);
            this.EnterFavLbl.Name = "EnterFavLbl";
            this.EnterFavLbl.Size = new System.Drawing.Size(158, 16);
            this.EnterFavLbl.TabIndex = 9;
            this.EnterFavLbl.Text = "Enter Favourite Name";
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(918, 512);
            this.Controls.Add(this.EnterFavLbl);
            this.Controls.Add(this.EnterFavTxtBox);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.labelDSF);
            this.Controls.Add(this.shiftButton);
            this.Controls.Add(this.favourite_box);
            this.Controls.Add(this.add_fav_btn);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.del_fav_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingDialog";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        public System.Windows.Forms.Button del_fav_btn;
        public System.Windows.Forms.Button set_btn;
        public System.Windows.Forms.Button add_fav_btn;
        public System.Windows.Forms.ComboBox favourite_box;
        private System.Windows.Forms.Button shiftButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDSF;
        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.TextBox EnterFavTxtBox;
        private System.Windows.Forms.Label EnterFavLbl;
    }
}