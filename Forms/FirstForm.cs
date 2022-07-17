using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewArnitaCharbelTabet_Project {

    public partial class FirstForm : Form {

        public bool flag = false;

        public static int gameCounter = 0;

        public FirstForm() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            IntroForm introForm = new IntroForm(); //Instantiate the IntroForm
            introForm.Show();
            this.Hide(); //Hides First Form
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {  //Exit the entire app when button X is pressed (avoiding the app to run in the background)
            if (flag == true)
                Application.Exit();
        }
    }
}
