namespace AndrewArnitaCharbelTabet_Project {
    partial class FirstForm {
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
            this.btnStart = new System.Windows.Forms.Button();
            this.TitleMilitaryWar = new System.Windows.Forms.Label();
            this.DevelopedBy = new System.Windows.Forms.Label();
            this.ArnitaCharbelLogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArnitaCharbelLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Lucida Fax", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnStart.Location = new System.Drawing.Point(397, 619);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(271, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TitleMilitaryWar
            // 
            this.TitleMilitaryWar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleMilitaryWar.AutoSize = true;
            this.TitleMilitaryWar.BackColor = System.Drawing.Color.Black;
            this.TitleMilitaryWar.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMilitaryWar.ForeColor = System.Drawing.Color.OrangeRed;
            this.TitleMilitaryWar.Location = new System.Drawing.Point(364, 9);
            this.TitleMilitaryWar.Name = "TitleMilitaryWar";
            this.TitleMilitaryWar.Size = new System.Drawing.Size(372, 62);
            this.TitleMilitaryWar.TabIndex = 7;
            this.TitleMilitaryWar.Text = "Military War";
            // 
            // DevelopedBy
            // 
            this.DevelopedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DevelopedBy.AutoSize = true;
            this.DevelopedBy.BackColor = System.Drawing.Color.Black;
            this.DevelopedBy.Font = new System.Drawing.Font("Lucida Fax", 18.32727F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedBy.ForeColor = System.Drawing.Color.OrangeRed;
            this.DevelopedBy.Location = new System.Drawing.Point(12, 567);
            this.DevelopedBy.Name = "DevelopedBy";
            this.DevelopedBy.Size = new System.Drawing.Size(222, 33);
            this.DevelopedBy.TabIndex = 8;
            this.DevelopedBy.Text = "Developed By:";
            // 
            // ArnitaCharbelLogoBox
            // 
            this.ArnitaCharbelLogoBox.BackColor = System.Drawing.Color.Black;
            this.ArnitaCharbelLogoBox.BackgroundImage = global::AndrewArnitaCharbelTabet_Project.Properties.Resources.DevelopersLogo;
            this.ArnitaCharbelLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArnitaCharbelLogoBox.Location = new System.Drawing.Point(18, 621);
            this.ArnitaCharbelLogoBox.Name = "ArnitaCharbelLogoBox";
            this.ArnitaCharbelLogoBox.Size = new System.Drawing.Size(219, 50);
            this.ArnitaCharbelLogoBox.TabIndex = 9;
            this.ArnitaCharbelLogoBox.TabStop = false;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = global::AndrewArnitaCharbelTabet_Project.Properties.Resources.firstimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 702);
            this.Controls.Add(this.ArnitaCharbelLogoBox);
            this.Controls.Add(this.DevelopedBy);
            this.Controls.Add(this.TitleMilitaryWar);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Military War";
            ((System.ComponentModel.ISupportInitialize)(this.ArnitaCharbelLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label TitleMilitaryWar;
        private System.Windows.Forms.Label DevelopedBy;
        private System.Windows.Forms.PictureBox ArnitaCharbelLogoBox;
    }
}

