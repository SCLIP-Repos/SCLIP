﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace SCLIP.View.Item
=======
namespace $safeprojectname$.View.Item
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
{
    public partial class Show : UserControl
    {
        public Show()
        {
            InitializeComponent();
        }
        public void SET(string Service, string URL, string Nicname, string ID, string Passwd, string Mail, string TEL, string Memo)
        {
            Service_label.Text = Service;

            URL_label.Text = URL;

            Nicname_label.Text = Nicname;

            ID_label.Text = ID;

            Passwd_label.Text = Passwd;

            Mail_label.Text = Mail;

            TEL_label.Text = TEL;

            Memo_richTextBox.Text = Memo;
        }
    }
}
