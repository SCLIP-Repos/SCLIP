﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.SetupUserControls
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Next1_button_Click(object sender, EventArgs e)
        {
            Setup.SwitchUserControl(Setup.Mode.Agree);
        }
    }
}