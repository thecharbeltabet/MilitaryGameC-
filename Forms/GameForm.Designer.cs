namespace AndrewArnitaCharbelTabet_Project {
    partial class GameForm {
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
            this.components = new System.ComponentModel.Container();
            this.BattlesListBox = new System.Windows.Forms.ListBox();
            this.BtnAutomaticSimulation = new System.Windows.Forms.Button();
            this.GameFormTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerNameText2 = new System.Windows.Forms.Label();
            this.PlayerNameText1 = new System.Windows.Forms.Label();
            this.VsText = new System.Windows.Forms.Label();
            this.GroupBoxGeneral2 = new System.Windows.Forms.GroupBox();
            this.TotalLifeGeneralText2 = new System.Windows.Forms.Label();
            this.TotalLifeGeneral2 = new System.Windows.Forms.Label();
            this.ArmyMemberAmmunitionText2 = new System.Windows.Forms.Label();
            this.ArmyMemberLifeText2 = new System.Windows.Forms.Label();
            this.VehiculesLeftText2 = new System.Windows.Forms.Label();
            this.SoldiersLeftText2 = new System.Windows.Forms.Label();
            this.VehiculesLeftGeneral2 = new System.Windows.Forms.Label();
            this.SoldierLeftGeneral2 = new System.Windows.Forms.Label();
            this.AmmunitionGeneral2 = new System.Windows.Forms.Label();
            this.LifeGeneral2 = new System.Windows.Forms.Label();
            this.GroupBoxGeneral1 = new System.Windows.Forms.GroupBox();
            this.TotalLifeGeneralText1 = new System.Windows.Forms.Label();
            this.TotalLifeGeneral1 = new System.Windows.Forms.Label();
            this.ArmyMemberAmmunitionText1 = new System.Windows.Forms.Label();
            this.ArmyMemberLifeText1 = new System.Windows.Forms.Label();
            this.VehiculesLeftText1 = new System.Windows.Forms.Label();
            this.SoldiersLeftText1 = new System.Windows.Forms.Label();
            this.VehiculesLeftGeneral1 = new System.Windows.Forms.Label();
            this.SoldiersLeftGeneral1 = new System.Windows.Forms.Label();
            this.LifeGeneral1 = new System.Windows.Forms.Label();
            this.AmmunitionGeneral1 = new System.Windows.Forms.Label();
            this.GeneralText1 = new System.Windows.Forms.Label();
            this.GeneralText2 = new System.Windows.Forms.Label();
            this.GeneralImage2 = new System.Windows.Forms.PictureBox();
            this.BattleCounterText = new System.Windows.Forms.Label();
            this.GeneralImage1 = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnEndgame = new System.Windows.Forms.Button();
            this.BtnFinishGame = new System.Windows.Forms.Button();
            this.GroupBoxGeneral2.SuspendLayout();
            this.GroupBoxGeneral1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // BattlesListBox
            // 
            this.BattlesListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BattlesListBox.BackColor = System.Drawing.Color.Black;
            this.BattlesListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BattlesListBox.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattlesListBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.BattlesListBox.FormattingEnabled = true;
            this.BattlesListBox.ItemHeight = 35;
            this.BattlesListBox.Location = new System.Drawing.Point(12, 17);
            this.BattlesListBox.Name = "BattlesListBox";
            this.BattlesListBox.Size = new System.Drawing.Size(258, 669);
            this.BattlesListBox.TabIndex = 0;
            this.BattlesListBox.Click += new System.EventHandler(this.BattlesListBox_Click);
            // 
            // BtnAutomaticSimulation
            // 
            this.BtnAutomaticSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAutomaticSimulation.BackColor = System.Drawing.Color.Black;
            this.BtnAutomaticSimulation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutomaticSimulation.Font = new System.Drawing.Font("Lucida Fax", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutomaticSimulation.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnAutomaticSimulation.Location = new System.Drawing.Point(12, 692);
            this.BtnAutomaticSimulation.Name = "BtnAutomaticSimulation";
            this.BtnAutomaticSimulation.Size = new System.Drawing.Size(258, 80);
            this.BtnAutomaticSimulation.TabIndex = 1;
            this.BtnAutomaticSimulation.Text = "Automatic";
            this.BtnAutomaticSimulation.UseVisualStyleBackColor = false;
            this.BtnAutomaticSimulation.Click += new System.EventHandler(this.BtnAutomaticSimulation_Click);
            // 
            // GameFormTimer
            // 
            this.GameFormTimer.Interval = 2000;
            this.GameFormTimer.Tick += new System.EventHandler(this.GameFormTimer_Tick);
            // 
            // PlayerNameText2
            // 
            this.PlayerNameText2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PlayerNameText2.AutoSize = true;
            this.PlayerNameText2.BackColor = System.Drawing.Color.Black;
            this.PlayerNameText2.Font = new System.Drawing.Font("Lucida Fax", 18.32727F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameText2.ForeColor = System.Drawing.Color.Blue;
            this.PlayerNameText2.Location = new System.Drawing.Point(995, 388);
            this.PlayerNameText2.Name = "PlayerNameText2";
            this.PlayerNameText2.Size = new System.Drawing.Size(24, 33);
            this.PlayerNameText2.TabIndex = 22;
            this.PlayerNameText2.Text = " ";
            // 
            // PlayerNameText1
            // 
            this.PlayerNameText1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerNameText1.AutoSize = true;
            this.PlayerNameText1.BackColor = System.Drawing.Color.Black;
            this.PlayerNameText1.Font = new System.Drawing.Font("Lucida Fax", 18.32727F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameText1.ForeColor = System.Drawing.Color.Blue;
            this.PlayerNameText1.Location = new System.Drawing.Point(412, 388);
            this.PlayerNameText1.Name = "PlayerNameText1";
            this.PlayerNameText1.Size = new System.Drawing.Size(24, 33);
            this.PlayerNameText1.TabIndex = 21;
            this.PlayerNameText1.Text = " ";
            // 
            // VsText
            // 
            this.VsText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VsText.AutoSize = true;
            this.VsText.BackColor = System.Drawing.Color.Black;
            this.VsText.Font = new System.Drawing.Font("Lucida Fax", 26.18182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsText.ForeColor = System.Drawing.Color.OrangeRed;
            this.VsText.Location = new System.Drawing.Point(817, 248);
            this.VsText.Name = "VsText";
            this.VsText.Size = new System.Drawing.Size(73, 46);
            this.VsText.TabIndex = 20;
            this.VsText.Text = "VS";
            // 
            // GroupBoxGeneral2
            // 
            this.GroupBoxGeneral2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GroupBoxGeneral2.BackColor = System.Drawing.Color.Black;
            this.GroupBoxGeneral2.Controls.Add(this.TotalLifeGeneralText2);
            this.GroupBoxGeneral2.Controls.Add(this.TotalLifeGeneral2);
            this.GroupBoxGeneral2.Controls.Add(this.ArmyMemberAmmunitionText2);
            this.GroupBoxGeneral2.Controls.Add(this.ArmyMemberLifeText2);
            this.GroupBoxGeneral2.Controls.Add(this.VehiculesLeftText2);
            this.GroupBoxGeneral2.Controls.Add(this.SoldiersLeftText2);
            this.GroupBoxGeneral2.Controls.Add(this.VehiculesLeftGeneral2);
            this.GroupBoxGeneral2.Controls.Add(this.SoldierLeftGeneral2);
            this.GroupBoxGeneral2.Controls.Add(this.AmmunitionGeneral2);
            this.GroupBoxGeneral2.Controls.Add(this.LifeGeneral2);
            this.GroupBoxGeneral2.Font = new System.Drawing.Font("Lucida Fax", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxGeneral2.ForeColor = System.Drawing.Color.OrangeRed;
            this.GroupBoxGeneral2.Location = new System.Drawing.Point(945, 440);
            this.GroupBoxGeneral2.Name = "GroupBoxGeneral2";
            this.GroupBoxGeneral2.Size = new System.Drawing.Size(342, 241);
            this.GroupBoxGeneral2.TabIndex = 19;
            this.GroupBoxGeneral2.TabStop = false;
            this.GroupBoxGeneral2.Text = "Army 2:";
            // 
            // TotalLifeGeneralText2
            // 
            this.TotalLifeGeneralText2.AutoSize = true;
            this.TotalLifeGeneralText2.ForeColor = System.Drawing.Color.Crimson;
            this.TotalLifeGeneralText2.Location = new System.Drawing.Point(218, 204);
            this.TotalLifeGeneralText2.Name = "TotalLifeGeneralText2";
            this.TotalLifeGeneralText2.Size = new System.Drawing.Size(17, 24);
            this.TotalLifeGeneralText2.TabIndex = 10;
            this.TotalLifeGeneralText2.Text = " ";
            // 
            // TotalLifeGeneral2
            // 
            this.TotalLifeGeneral2.AutoSize = true;
            this.TotalLifeGeneral2.ForeColor = System.Drawing.Color.OrangeRed;
            this.TotalLifeGeneral2.Location = new System.Drawing.Point(10, 204);
            this.TotalLifeGeneral2.Name = "TotalLifeGeneral2";
            this.TotalLifeGeneral2.Size = new System.Drawing.Size(123, 24);
            this.TotalLifeGeneral2.TabIndex = 9;
            this.TotalLifeGeneral2.Text = "Total Life:";
            // 
            // ArmyMemberAmmunitionText2
            // 
            this.ArmyMemberAmmunitionText2.AutoSize = true;
            this.ArmyMemberAmmunitionText2.ForeColor = System.Drawing.Color.Crimson;
            this.ArmyMemberAmmunitionText2.Location = new System.Drawing.Point(218, 78);
            this.ArmyMemberAmmunitionText2.Name = "ArmyMemberAmmunitionText2";
            this.ArmyMemberAmmunitionText2.Size = new System.Drawing.Size(17, 24);
            this.ArmyMemberAmmunitionText2.TabIndex = 8;
            this.ArmyMemberAmmunitionText2.Text = " ";
            // 
            // ArmyMemberLifeText2
            // 
            this.ArmyMemberLifeText2.AutoSize = true;
            this.ArmyMemberLifeText2.ForeColor = System.Drawing.Color.Crimson;
            this.ArmyMemberLifeText2.Location = new System.Drawing.Point(218, 39);
            this.ArmyMemberLifeText2.Name = "ArmyMemberLifeText2";
            this.ArmyMemberLifeText2.Size = new System.Drawing.Size(17, 24);
            this.ArmyMemberLifeText2.TabIndex = 7;
            this.ArmyMemberLifeText2.Text = " ";
            // 
            // VehiculesLeftText2
            // 
            this.VehiculesLeftText2.AutoSize = true;
            this.VehiculesLeftText2.ForeColor = System.Drawing.Color.Crimson;
            this.VehiculesLeftText2.Location = new System.Drawing.Point(218, 163);
            this.VehiculesLeftText2.Name = "VehiculesLeftText2";
            this.VehiculesLeftText2.Size = new System.Drawing.Size(17, 24);
            this.VehiculesLeftText2.TabIndex = 6;
            this.VehiculesLeftText2.Text = " ";
            // 
            // SoldiersLeftText2
            // 
            this.SoldiersLeftText2.AutoSize = true;
            this.SoldiersLeftText2.ForeColor = System.Drawing.Color.Crimson;
            this.SoldiersLeftText2.Location = new System.Drawing.Point(218, 120);
            this.SoldiersLeftText2.Name = "SoldiersLeftText2";
            this.SoldiersLeftText2.Size = new System.Drawing.Size(17, 24);
            this.SoldiersLeftText2.TabIndex = 5;
            this.SoldiersLeftText2.Text = " ";
            // 
            // VehiculesLeftGeneral2
            // 
            this.VehiculesLeftGeneral2.AutoSize = true;
            this.VehiculesLeftGeneral2.ForeColor = System.Drawing.Color.OrangeRed;
            this.VehiculesLeftGeneral2.Location = new System.Drawing.Point(6, 163);
            this.VehiculesLeftGeneral2.Name = "VehiculesLeftGeneral2";
            this.VehiculesLeftGeneral2.Size = new System.Drawing.Size(175, 24);
            this.VehiculesLeftGeneral2.TabIndex = 3;
            this.VehiculesLeftGeneral2.Text = "Vehicules Left:";
            // 
            // SoldierLeftGeneral2
            // 
            this.SoldierLeftGeneral2.AutoSize = true;
            this.SoldierLeftGeneral2.ForeColor = System.Drawing.Color.OrangeRed;
            this.SoldierLeftGeneral2.Location = new System.Drawing.Point(6, 120);
            this.SoldierLeftGeneral2.Name = "SoldierLeftGeneral2";
            this.SoldierLeftGeneral2.Size = new System.Drawing.Size(157, 24);
            this.SoldierLeftGeneral2.TabIndex = 2;
            this.SoldierLeftGeneral2.Text = "Soldiers Left:";
            // 
            // AmmunitionGeneral2
            // 
            this.AmmunitionGeneral2.AutoSize = true;
            this.AmmunitionGeneral2.ForeColor = System.Drawing.Color.OrangeRed;
            this.AmmunitionGeneral2.Location = new System.Drawing.Point(6, 78);
            this.AmmunitionGeneral2.Name = "AmmunitionGeneral2";
            this.AmmunitionGeneral2.Size = new System.Drawing.Size(154, 24);
            this.AmmunitionGeneral2.TabIndex = 1;
            this.AmmunitionGeneral2.Text = "Ammunition:";
            // 
            // LifeGeneral2
            // 
            this.LifeGeneral2.AutoSize = true;
            this.LifeGeneral2.ForeColor = System.Drawing.Color.OrangeRed;
            this.LifeGeneral2.Location = new System.Drawing.Point(6, 39);
            this.LifeGeneral2.Name = "LifeGeneral2";
            this.LifeGeneral2.Size = new System.Drawing.Size(59, 24);
            this.LifeGeneral2.TabIndex = 0;
            this.LifeGeneral2.Text = "Life:";
            // 
            // GroupBoxGeneral1
            // 
            this.GroupBoxGeneral1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GroupBoxGeneral1.BackColor = System.Drawing.Color.Black;
            this.GroupBoxGeneral1.Controls.Add(this.TotalLifeGeneralText1);
            this.GroupBoxGeneral1.Controls.Add(this.TotalLifeGeneral1);
            this.GroupBoxGeneral1.Controls.Add(this.ArmyMemberAmmunitionText1);
            this.GroupBoxGeneral1.Controls.Add(this.ArmyMemberLifeText1);
            this.GroupBoxGeneral1.Controls.Add(this.VehiculesLeftText1);
            this.GroupBoxGeneral1.Controls.Add(this.SoldiersLeftText1);
            this.GroupBoxGeneral1.Controls.Add(this.VehiculesLeftGeneral1);
            this.GroupBoxGeneral1.Controls.Add(this.SoldiersLeftGeneral1);
            this.GroupBoxGeneral1.Controls.Add(this.LifeGeneral1);
            this.GroupBoxGeneral1.Controls.Add(this.AmmunitionGeneral1);
            this.GroupBoxGeneral1.Font = new System.Drawing.Font("Lucida Fax", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxGeneral1.ForeColor = System.Drawing.Color.OrangeRed;
            this.GroupBoxGeneral1.Location = new System.Drawing.Point(408, 440);
            this.GroupBoxGeneral1.Name = "GroupBoxGeneral1";
            this.GroupBoxGeneral1.Size = new System.Drawing.Size(349, 241);
            this.GroupBoxGeneral1.TabIndex = 18;
            this.GroupBoxGeneral1.TabStop = false;
            this.GroupBoxGeneral1.Text = "Army 1:";
            // 
            // TotalLifeGeneralText1
            // 
            this.TotalLifeGeneralText1.AutoSize = true;
            this.TotalLifeGeneralText1.ForeColor = System.Drawing.Color.Crimson;
            this.TotalLifeGeneralText1.Location = new System.Drawing.Point(220, 204);
            this.TotalLifeGeneralText1.Name = "TotalLifeGeneralText1";
            this.TotalLifeGeneralText1.Size = new System.Drawing.Size(17, 24);
            this.TotalLifeGeneralText1.TabIndex = 9;
            this.TotalLifeGeneralText1.Text = " ";
            // 
            // TotalLifeGeneral1
            // 
            this.TotalLifeGeneral1.AutoSize = true;
            this.TotalLifeGeneral1.ForeColor = System.Drawing.Color.OrangeRed;
            this.TotalLifeGeneral1.Location = new System.Drawing.Point(10, 204);
            this.TotalLifeGeneral1.Name = "TotalLifeGeneral1";
            this.TotalLifeGeneral1.Size = new System.Drawing.Size(123, 24);
            this.TotalLifeGeneral1.TabIndex = 8;
            this.TotalLifeGeneral1.Text = "Total Life:";
            // 
            // ArmyMemberAmmunitionText1
            // 
            this.ArmyMemberAmmunitionText1.AutoSize = true;
            this.ArmyMemberAmmunitionText1.ForeColor = System.Drawing.Color.Crimson;
            this.ArmyMemberAmmunitionText1.Location = new System.Drawing.Point(220, 78);
            this.ArmyMemberAmmunitionText1.Name = "ArmyMemberAmmunitionText1";
            this.ArmyMemberAmmunitionText1.Size = new System.Drawing.Size(17, 24);
            this.ArmyMemberAmmunitionText1.TabIndex = 7;
            this.ArmyMemberAmmunitionText1.Text = " ";
            // 
            // ArmyMemberLifeText1
            // 
            this.ArmyMemberLifeText1.AutoSize = true;
            this.ArmyMemberLifeText1.ForeColor = System.Drawing.Color.Crimson;
            this.ArmyMemberLifeText1.Location = new System.Drawing.Point(220, 39);
            this.ArmyMemberLifeText1.Name = "ArmyMemberLifeText1";
            this.ArmyMemberLifeText1.Size = new System.Drawing.Size(17, 24);
            this.ArmyMemberLifeText1.TabIndex = 6;
            this.ArmyMemberLifeText1.Text = " ";
            // 
            // VehiculesLeftText1
            // 
            this.VehiculesLeftText1.AutoSize = true;
            this.VehiculesLeftText1.ForeColor = System.Drawing.Color.Crimson;
            this.VehiculesLeftText1.Location = new System.Drawing.Point(220, 163);
            this.VehiculesLeftText1.Name = "VehiculesLeftText1";
            this.VehiculesLeftText1.Size = new System.Drawing.Size(17, 24);
            this.VehiculesLeftText1.TabIndex = 5;
            this.VehiculesLeftText1.Text = " ";
            // 
            // SoldiersLeftText1
            // 
            this.SoldiersLeftText1.AutoSize = true;
            this.SoldiersLeftText1.ForeColor = System.Drawing.Color.Crimson;
            this.SoldiersLeftText1.Location = new System.Drawing.Point(220, 120);
            this.SoldiersLeftText1.Name = "SoldiersLeftText1";
            this.SoldiersLeftText1.Size = new System.Drawing.Size(17, 24);
            this.SoldiersLeftText1.TabIndex = 4;
            this.SoldiersLeftText1.Text = " ";
            // 
            // VehiculesLeftGeneral1
            // 
            this.VehiculesLeftGeneral1.AutoSize = true;
            this.VehiculesLeftGeneral1.ForeColor = System.Drawing.Color.OrangeRed;
            this.VehiculesLeftGeneral1.Location = new System.Drawing.Point(6, 163);
            this.VehiculesLeftGeneral1.Name = "VehiculesLeftGeneral1";
            this.VehiculesLeftGeneral1.Size = new System.Drawing.Size(175, 24);
            this.VehiculesLeftGeneral1.TabIndex = 3;
            this.VehiculesLeftGeneral1.Text = "Vehicules Left:";
            // 
            // SoldiersLeftGeneral1
            // 
            this.SoldiersLeftGeneral1.AutoSize = true;
            this.SoldiersLeftGeneral1.ForeColor = System.Drawing.Color.OrangeRed;
            this.SoldiersLeftGeneral1.Location = new System.Drawing.Point(6, 120);
            this.SoldiersLeftGeneral1.Name = "SoldiersLeftGeneral1";
            this.SoldiersLeftGeneral1.Size = new System.Drawing.Size(157, 24);
            this.SoldiersLeftGeneral1.TabIndex = 2;
            this.SoldiersLeftGeneral1.Text = "Soldiers Left:";
            // 
            // LifeGeneral1
            // 
            this.LifeGeneral1.AutoSize = true;
            this.LifeGeneral1.ForeColor = System.Drawing.Color.OrangeRed;
            this.LifeGeneral1.Location = new System.Drawing.Point(6, 39);
            this.LifeGeneral1.Name = "LifeGeneral1";
            this.LifeGeneral1.Size = new System.Drawing.Size(59, 24);
            this.LifeGeneral1.TabIndex = 1;
            this.LifeGeneral1.Text = "Life:";
            // 
            // AmmunitionGeneral1
            // 
            this.AmmunitionGeneral1.AutoSize = true;
            this.AmmunitionGeneral1.ForeColor = System.Drawing.Color.OrangeRed;
            this.AmmunitionGeneral1.Location = new System.Drawing.Point(6, 78);
            this.AmmunitionGeneral1.Name = "AmmunitionGeneral1";
            this.AmmunitionGeneral1.Size = new System.Drawing.Size(154, 24);
            this.AmmunitionGeneral1.TabIndex = 0;
            this.AmmunitionGeneral1.Text = "Ammunition:";
            // 
            // GeneralText1
            // 
            this.GeneralText1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralText1.AutoSize = true;
            this.GeneralText1.BackColor = System.Drawing.Color.Black;
            this.GeneralText1.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralText1.ForeColor = System.Drawing.Color.Blue;
            this.GeneralText1.Location = new System.Drawing.Point(408, 108);
            this.GeneralText1.Name = "GeneralText1";
            this.GeneralText1.Size = new System.Drawing.Size(28, 38);
            this.GeneralText1.TabIndex = 16;
            this.GeneralText1.Text = " ";
            // 
            // GeneralText2
            // 
            this.GeneralText2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GeneralText2.AutoSize = true;
            this.GeneralText2.BackColor = System.Drawing.Color.Black;
            this.GeneralText2.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralText2.ForeColor = System.Drawing.Color.Blue;
            this.GeneralText2.Location = new System.Drawing.Point(991, 108);
            this.GeneralText2.Name = "GeneralText2";
            this.GeneralText2.Size = new System.Drawing.Size(28, 38);
            this.GeneralText2.TabIndex = 15;
            this.GeneralText2.Text = " ";
            // 
            // GeneralImage2
            // 
            this.GeneralImage2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GeneralImage2.BackColor = System.Drawing.Color.Transparent;
            this.GeneralImage2.Location = new System.Drawing.Point(986, 169);
            this.GeneralImage2.Name = "GeneralImage2";
            this.GeneralImage2.Size = new System.Drawing.Size(301, 205);
            this.GeneralImage2.TabIndex = 14;
            this.GeneralImage2.TabStop = false;
            // 
            // BattleCounterText
            // 
            this.BattleCounterText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BattleCounterText.AutoSize = true;
            this.BattleCounterText.BackColor = System.Drawing.Color.Black;
            this.BattleCounterText.Font = new System.Drawing.Font("Lucida Fax", 20.29091F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleCounterText.ForeColor = System.Drawing.Color.OrangeRed;
            this.BattleCounterText.Location = new System.Drawing.Point(790, 17);
            this.BattleCounterText.Name = "BattleCounterText";
            this.BattleCounterText.Size = new System.Drawing.Size(115, 38);
            this.BattleCounterText.TabIndex = 13;
            this.BattleCounterText.Text = "Battle";
            // 
            // GeneralImage1
            // 
            this.GeneralImage1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralImage1.BackColor = System.Drawing.Color.Transparent;
            this.GeneralImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeneralImage1.Location = new System.Drawing.Point(408, 169);
            this.GeneralImage1.Name = "GeneralImage1";
            this.GeneralImage1.Size = new System.Drawing.Size(302, 205);
            this.GeneralImage1.TabIndex = 12;
            this.GeneralImage1.TabStop = false;
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnStop.BackColor = System.Drawing.Color.Black;
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.Font = new System.Drawing.Font("Lucida Fax", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnStop.Location = new System.Drawing.Point(438, 692);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(258, 80);
            this.BtnStop.TabIndex = 23;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnEndgame
            // 
            this.BtnEndgame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEndgame.BackColor = System.Drawing.Color.Black;
            this.BtnEndgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEndgame.Font = new System.Drawing.Font("Lucida Fax", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEndgame.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnEndgame.Location = new System.Drawing.Point(986, 692);
            this.BtnEndgame.Name = "BtnEndgame";
            this.BtnEndgame.Size = new System.Drawing.Size(258, 80);
            this.BtnEndgame.TabIndex = 24;
            this.BtnEndgame.Text = "End Game";
            this.BtnEndgame.UseVisualStyleBackColor = false;
            this.BtnEndgame.Click += new System.EventHandler(this.BtnEndgame_Click);
            // 
            // BtnFinishGame
            // 
            this.BtnFinishGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnFinishGame.BackColor = System.Drawing.Color.Black;
            this.BtnFinishGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinishGame.Font = new System.Drawing.Font("Lucida Fax", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinishGame.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnFinishGame.Location = new System.Drawing.Point(793, 692);
            this.BtnFinishGame.Name = "BtnFinishGame";
            this.BtnFinishGame.Size = new System.Drawing.Size(112, 80);
            this.BtnFinishGame.TabIndex = 25;
            this.BtnFinishGame.Text = "Finish";
            this.BtnFinishGame.UseVisualStyleBackColor = false;
            this.BtnFinishGame.Click += new System.EventHandler(this.BtnFinishGame_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::AndrewArnitaCharbelTabet_Project.Properties.Resources.armyman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 777);
            this.Controls.Add(this.BtnFinishGame);
            this.Controls.Add(this.BtnEndgame);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.PlayerNameText2);
            this.Controls.Add(this.PlayerNameText1);
            this.Controls.Add(this.VsText);
            this.Controls.Add(this.GroupBoxGeneral2);
            this.Controls.Add(this.GroupBoxGeneral1);
            this.Controls.Add(this.GeneralText1);
            this.Controls.Add(this.GeneralText2);
            this.Controls.Add(this.GeneralImage2);
            this.Controls.Add(this.BattleCounterText);
            this.Controls.Add(this.GeneralImage1);
            this.Controls.Add(this.BtnAutomaticSimulation);
            this.Controls.Add(this.BattlesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War!";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.GroupBoxGeneral2.ResumeLayout(false);
            this.GroupBoxGeneral2.PerformLayout();
            this.GroupBoxGeneral1.ResumeLayout(false);
            this.GroupBoxGeneral1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BattlesListBox;
        private System.Windows.Forms.Button BtnAutomaticSimulation;
        public System.Windows.Forms.Timer GameFormTimer;
        private System.Windows.Forms.Label PlayerNameText2;
        private System.Windows.Forms.Label PlayerNameText1;
        private System.Windows.Forms.Label VsText;
        private System.Windows.Forms.GroupBox GroupBoxGeneral2;
        private System.Windows.Forms.Label ArmyMemberAmmunitionText2;
        private System.Windows.Forms.Label ArmyMemberLifeText2;
        private System.Windows.Forms.Label VehiculesLeftText2;
        private System.Windows.Forms.Label SoldiersLeftText2;
        private System.Windows.Forms.Label VehiculesLeftGeneral2;
        private System.Windows.Forms.Label SoldierLeftGeneral2;
        private System.Windows.Forms.Label AmmunitionGeneral2;
        private System.Windows.Forms.Label LifeGeneral2;
        private System.Windows.Forms.GroupBox GroupBoxGeneral1;
        private System.Windows.Forms.Label ArmyMemberAmmunitionText1;
        private System.Windows.Forms.Label ArmyMemberLifeText1;
        private System.Windows.Forms.Label VehiculesLeftText1;
        private System.Windows.Forms.Label SoldiersLeftText1;
        private System.Windows.Forms.Label VehiculesLeftGeneral1;
        private System.Windows.Forms.Label SoldiersLeftGeneral1;
        private System.Windows.Forms.Label LifeGeneral1;
        private System.Windows.Forms.Label AmmunitionGeneral1;
        private System.Windows.Forms.Label GeneralText1;
        public System.Windows.Forms.Label GeneralText2;
        private System.Windows.Forms.PictureBox GeneralImage2;
        private System.Windows.Forms.Label BattleCounterText;
        private System.Windows.Forms.PictureBox GeneralImage1;
        private System.Windows.Forms.Label TotalLifeGeneralText2;
        private System.Windows.Forms.Label TotalLifeGeneral2;
        private System.Windows.Forms.Label TotalLifeGeneralText1;
        private System.Windows.Forms.Label TotalLifeGeneral1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnEndgame;
        private System.Windows.Forms.Button BtnFinishGame;
    }
}