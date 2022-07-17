namespace AndrewArnitaCharbelTabet_Project {
    partial class IntroForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.WelcomeIntroText = new System.Windows.Forms.Label();
            this.IntroText = new System.Windows.Forms.Label();
            this.btnWar = new System.Windows.Forms.Button();
            this.GeneralField1 = new System.Windows.Forms.TextBox();
            this.GeneralsNamesText = new System.Windows.Forms.Label();
            this.GeneralField2 = new System.Windows.Forms.TextBox();
            this.FirstGeneralText = new System.Windows.Forms.Label();
            this.SecondGeneralText = new System.Windows.Forms.Label();
            this.NumberOftext = new System.Windows.Forms.Label();
            this.VehiculesText = new System.Windows.Forms.Label();
            this.SolidersText = new System.Windows.Forms.Label();
            this.SoldiersField = new System.Windows.Forms.TextBox();
            this.VehiculesField = new System.Windows.Forms.TextBox();
            this.BattlesField = new System.Windows.Forms.TextBox();
            this.BattleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeIntroText
            // 
            this.WelcomeIntroText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WelcomeIntroText.AutoSize = true;
            this.WelcomeIntroText.BackColor = System.Drawing.Color.Black;
            this.WelcomeIntroText.Font = new System.Drawing.Font("Lucida Fax", 28.14545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeIntroText.ForeColor = System.Drawing.Color.OrangeRed;
            this.WelcomeIntroText.Location = new System.Drawing.Point(336, 9);
            this.WelcomeIntroText.Name = "WelcomeIntroText";
            this.WelcomeIntroText.Size = new System.Drawing.Size(347, 49);
            this.WelcomeIntroText.TabIndex = 0;
            this.WelcomeIntroText.Text = "Wait Generals!";
            // 
            // IntroText
            // 
            this.IntroText.AutoSize = true;
            this.IntroText.BackColor = System.Drawing.Color.Transparent;
            this.IntroText.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroText.ForeColor = System.Drawing.Color.Red;
            this.IntroText.Location = new System.Drawing.Point(195, 89);
            this.IntroText.Name = "IntroText";
            this.IntroText.Size = new System.Drawing.Size(754, 148);
            this.IntroText.TabIndex = 1;
            this.IntroText.Text = "In this game you will try your best to survive! \r\nAs you know no one dies before " +
    "he lives, \r\nso do your best while engaging at enemies \r\nand I\'ll see you soon Ge" +
    "nerals!";
            // 
            // btnWar
            // 
            this.btnWar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWar.BackColor = System.Drawing.Color.Black;
            this.btnWar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWar.Font = new System.Drawing.Font("Lucida Fax", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnWar.Location = new System.Drawing.Point(378, 633);
            this.btnWar.Name = "btnWar";
            this.btnWar.Size = new System.Drawing.Size(271, 52);
            this.btnWar.TabIndex = 3;
            this.btnWar.Text = "War!";
            this.btnWar.UseVisualStyleBackColor = false;
            this.btnWar.Click += new System.EventHandler(this.BtnWar_Click);
            // 
            // GeneralField1
            // 
            this.GeneralField1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneralField1.BackColor = System.Drawing.Color.Black;
            this.GeneralField1.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralField1.ForeColor = System.Drawing.Color.OrangeRed;
            this.GeneralField1.Location = new System.Drawing.Point(188, 448);
            this.GeneralField1.MaxLength = 12;
            this.GeneralField1.Name = "GeneralField1";
            this.GeneralField1.Size = new System.Drawing.Size(191, 29);
            this.GeneralField1.TabIndex = 4;
            this.GeneralField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GeneralField1.TextChanged += new System.EventHandler(this.GeneralField1_TextChanged);
            this.GeneralField1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralField1_KeyPress);
            // 
            // GeneralsNamesText
            // 
            this.GeneralsNamesText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneralsNamesText.AutoSize = true;
            this.GeneralsNamesText.BackColor = System.Drawing.Color.Black;
            this.GeneralsNamesText.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralsNamesText.ForeColor = System.Drawing.Color.Blue;
            this.GeneralsNamesText.Location = new System.Drawing.Point(33, 306);
            this.GeneralsNamesText.Name = "GeneralsNamesText";
            this.GeneralsNamesText.Size = new System.Drawing.Size(481, 37);
            this.GeneralsNamesText.TabIndex = 5;
            this.GeneralsNamesText.Text = "Let\'s start with your names...";
            // 
            // GeneralField2
            // 
            this.GeneralField2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneralField2.BackColor = System.Drawing.Color.Black;
            this.GeneralField2.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralField2.ForeColor = System.Drawing.Color.OrangeRed;
            this.GeneralField2.Location = new System.Drawing.Point(188, 508);
            this.GeneralField2.MaxLength = 12;
            this.GeneralField2.Name = "GeneralField2";
            this.GeneralField2.Size = new System.Drawing.Size(191, 29);
            this.GeneralField2.TabIndex = 6;
            this.GeneralField2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GeneralField2.TextChanged += new System.EventHandler(this.GeneralField2_TextChanged);
            this.GeneralField2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralField2_KeyPress);
            // 
            // FirstGeneralText
            // 
            this.FirstGeneralText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FirstGeneralText.AutoSize = true;
            this.FirstGeneralText.BackColor = System.Drawing.Color.Transparent;
            this.FirstGeneralText.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstGeneralText.ForeColor = System.Drawing.Color.OrangeRed;
            this.FirstGeneralText.Location = new System.Drawing.Point(70, 451);
            this.FirstGeneralText.Name = "FirstGeneralText";
            this.FirstGeneralText.Size = new System.Drawing.Size(112, 22);
            this.FirstGeneralText.TabIndex = 7;
            this.FirstGeneralText.Text = "General 1:";
            // 
            // SecondGeneralText
            // 
            this.SecondGeneralText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SecondGeneralText.AutoSize = true;
            this.SecondGeneralText.BackColor = System.Drawing.Color.Transparent;
            this.SecondGeneralText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SecondGeneralText.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondGeneralText.ForeColor = System.Drawing.Color.OrangeRed;
            this.SecondGeneralText.Location = new System.Drawing.Point(70, 511);
            this.SecondGeneralText.Name = "SecondGeneralText";
            this.SecondGeneralText.Size = new System.Drawing.Size(112, 22);
            this.SecondGeneralText.TabIndex = 8;
            this.SecondGeneralText.Text = "General 2:";
            // 
            // NumberOftext
            // 
            this.NumberOftext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOftext.AutoSize = true;
            this.NumberOftext.BackColor = System.Drawing.Color.Black;
            this.NumberOftext.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOftext.ForeColor = System.Drawing.Color.Blue;
            this.NumberOftext.Location = new System.Drawing.Point(530, 306);
            this.NumberOftext.Name = "NumberOftext";
            this.NumberOftext.Size = new System.Drawing.Size(479, 37);
            this.NumberOftext.TabIndex = 9;
            this.NumberOftext.Text = "Please choose the number of:";
            // 
            // VehiculesText
            // 
            this.VehiculesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VehiculesText.AutoSize = true;
            this.VehiculesText.BackColor = System.Drawing.Color.Transparent;
            this.VehiculesText.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculesText.ForeColor = System.Drawing.Color.OrangeRed;
            this.VehiculesText.Location = new System.Drawing.Point(599, 487);
            this.VehiculesText.Name = "VehiculesText";
            this.VehiculesText.Size = new System.Drawing.Size(120, 22);
            this.VehiculesText.TabIndex = 10;
            this.VehiculesText.Text = "Vehicules: ";
            // 
            // SolidersText
            // 
            this.SolidersText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SolidersText.AutoSize = true;
            this.SolidersText.BackColor = System.Drawing.Color.Transparent;
            this.SolidersText.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolidersText.ForeColor = System.Drawing.Color.OrangeRed;
            this.SolidersText.Location = new System.Drawing.Point(599, 426);
            this.SolidersText.Name = "SolidersText";
            this.SolidersText.Size = new System.Drawing.Size(103, 22);
            this.SolidersText.TabIndex = 11;
            this.SolidersText.Text = "Soldiers: ";
            // 
            // SoldiersField
            // 
            this.SoldiersField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoldiersField.BackColor = System.Drawing.Color.Black;
            this.SoldiersField.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldiersField.ForeColor = System.Drawing.Color.OrangeRed;
            this.SoldiersField.Location = new System.Drawing.Point(725, 426);
            this.SoldiersField.MaxLength = 3;
            this.SoldiersField.Name = "SoldiersField";
            this.SoldiersField.Size = new System.Drawing.Size(89, 29);
            this.SoldiersField.TabIndex = 14;
            this.SoldiersField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoldiersField.TextChanged += new System.EventHandler(this.SoldiersField_TextChanged);
            this.SoldiersField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoldiersField_KeyPress);
            // 
            // VehiculesField
            // 
            this.VehiculesField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VehiculesField.BackColor = System.Drawing.Color.Black;
            this.VehiculesField.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculesField.ForeColor = System.Drawing.Color.OrangeRed;
            this.VehiculesField.Location = new System.Drawing.Point(725, 484);
            this.VehiculesField.MaxLength = 3;
            this.VehiculesField.Name = "VehiculesField";
            this.VehiculesField.Size = new System.Drawing.Size(89, 29);
            this.VehiculesField.TabIndex = 15;
            this.VehiculesField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VehiculesField.TextChanged += new System.EventHandler(this.VehiculesField_TextChanged);
            this.VehiculesField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VehiculesField_KeyPress);
            // 
            // BattlesField
            // 
            this.BattlesField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BattlesField.BackColor = System.Drawing.Color.Black;
            this.BattlesField.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattlesField.ForeColor = System.Drawing.Color.OrangeRed;
            this.BattlesField.Location = new System.Drawing.Point(725, 547);
            this.BattlesField.MaxLength = 4;
            this.BattlesField.Name = "BattlesField";
            this.BattlesField.Size = new System.Drawing.Size(89, 29);
            this.BattlesField.TabIndex = 16;
            this.BattlesField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BattlesField.TextChanged += new System.EventHandler(this.RoundField_TextChanged);
            this.BattlesField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoundField_KeyPress);
            // 
            // BattleText
            // 
            this.BattleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BattleText.AutoSize = true;
            this.BattleText.BackColor = System.Drawing.Color.Transparent;
            this.BattleText.Font = new System.Drawing.Font("Lucida Fax", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleText.ForeColor = System.Drawing.Color.OrangeRed;
            this.BattleText.Location = new System.Drawing.Point(599, 554);
            this.BattleText.Name = "BattleText";
            this.BattleText.Size = new System.Drawing.Size(84, 22);
            this.BattleText.TabIndex = 17;
            this.BattleText.Text = "Battles:";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::AndrewArnitaCharbelTabet_Project.Properties.Resources.introbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 697);
            this.Controls.Add(this.BattleText);
            this.Controls.Add(this.BattlesField);
            this.Controls.Add(this.VehiculesField);
            this.Controls.Add(this.SoldiersField);
            this.Controls.Add(this.SolidersText);
            this.Controls.Add(this.VehiculesText);
            this.Controls.Add(this.NumberOftext);
            this.Controls.Add(this.SecondGeneralText);
            this.Controls.Add(this.FirstGeneralText);
            this.Controls.Add(this.GeneralField2);
            this.Controls.Add(this.GeneralsNamesText);
            this.Controls.Add(this.GeneralField1);
            this.Controls.Add(this.btnWar);
            this.Controls.Add(this.IntroText);
            this.Controls.Add(this.WelcomeIntroText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wait Generals!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeIntroText;
        private System.Windows.Forms.Label IntroText;
        private System.Windows.Forms.Button btnWar;
        private System.Windows.Forms.TextBox GeneralField1;
        private System.Windows.Forms.Label GeneralsNamesText;
        private System.Windows.Forms.TextBox GeneralField2;
        private System.Windows.Forms.Label FirstGeneralText;
        private System.Windows.Forms.Label SecondGeneralText;
        private System.Windows.Forms.Label NumberOftext;
        private System.Windows.Forms.Label VehiculesText;
        private System.Windows.Forms.Label SolidersText;
        private System.Windows.Forms.TextBox SoldiersField;
        private System.Windows.Forms.TextBox VehiculesField;
        private System.Windows.Forms.TextBox BattlesField;
        private System.Windows.Forms.Label BattleText;
    }
}