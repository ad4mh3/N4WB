using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N4WB_Browser.gui
{
    public partial class warning : Form
    {
        public warning()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
