namespace AndrewArnitaCharbelTabet_Project {
    partial class ResultsForm {
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
            this.BtnExitGame = new System.Windows.Forms.Button();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.WarResultsText = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnExitGame
            // 
            this.BtnExitGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExitGame.BackColor = System.Drawing.Color.Black;
            this.BtnExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitGame.Font = new System.Drawing.Font("Lucida Fax", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitGame.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnExitGame.Location = new System.Drawing.Point(460, 637);
            this.BtnExitGame.Name = "BtnExitGame";
            this.BtnExitGame.Size = new System.Drawing.Size(258, 80);
            this.BtnExitGame.TabIndex = 3;
            this.BtnExitGame.Text = "Exit";
            this.BtnExitGame.UseVisualStyleBackColor = false;
            this.BtnExitGame.Click += new System.EventHandler(this.BtnExitGame_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewGame.BackColor = System.Drawing.Color.Black;
            this.BtnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewGame.Font = new System.Drawing.Font("Lucida Fax", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGame.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnNewGame.Location = new System.Drawing.Point(878, 637);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(258, 80);
            this.BtnNewGame.TabIndex = 4;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.UseVisualStyleBackColor = false;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // WarResultsText
            // 
            this.WarResultsText.AutoSize = true;
            this.WarResultsText.BackColor = System.Drawing.Color.Black;
            this.WarResultsText.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarResultsText.ForeColor = System.Drawing.Color.OrangeRed;
            this.WarResultsText.Location = new System.Drawing.Point(12, 9);
            this.WarResultsText.Name = "WarResultsText";
            this.WarResultsText.Size = new System.Drawing.Size(389, 63);
            this.WarResultsText.TabIndex = 14;
            this.WarResultsText.Text = "War Results!";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.BackColor = System.Drawing.Color.Black;
            this.ResultsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultsListBox.Font = new System.Drawing.Font("Lucida Fax", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsListBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 32;
            this.ResultsListBox.Location = new System.Drawing.Point(12, 127);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(589, 452);
            this.ResultsListBox.TabIndex = 15;
            this.ResultsListBox.DoubleClick += new System.EventHandler(this.ResultsListBox_DoubleClick);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AndrewArnitaCharbelTabet_Project.Properties.Resources.result_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 729);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.WarResultsText);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.BtnExitGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War Results!";
            this.Load += new System.EventHandler(this.ResultsForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnExitGame;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Label WarResultsText;
        private System.Windows.Forms.ListBox ResultsListBox;
    }
}