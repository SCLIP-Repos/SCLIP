﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FSys;

<<<<<<< HEAD
namespace SCLIP
{
    public partial class Form1 : Form
    {
        private static View.Item.Control _controlView;

        private static View.Item.Show _showView;



        public Form1()
        {
            InitializeComponent();

            Registration();
=======
namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        internal void LoadItem()
        {
            /*
            string[] tmp = FileIO.GetAllFiles(Act.Configuration.Control.Path.SavePath);


            for (int i = 0; i < tmp.Length; i++)
                Item_listBox.Items.Add( System.IO.Path.GetFileNameWithoutExtension(tmp[i]) );*/
        }
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b

            Switch(Channel.Init);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(!Group.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\$safeprojectname$"))
            {
<<<<<<< HEAD
                case Channel.Init:
                    _controlView.Visible = false;
                    _showView.Visible = false;
                    break;

                case Channel.Control:
                    Switch(Channel.Init);
                    _controlView.Visible = true;
                    break;

                case Channel.Show:
                    Switch(Channel.Init);
                    _showView.Visible = true;
                    break;
=======
                SetupForm setupForm = new SetupForm();

                SetupForm.Switch(SetupForm.Channel.Welcome);

                setupForm.ShowDialog();
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
            }


<<<<<<< HEAD
        private void Registration()
        {
            _controlView = new View.Item.Control();

            _showView = new View.Item.Show();

            Base_panel.Controls.Add(_controlView);

            Base_panel.Controls.Add(_showView);

        }


        private void LoadItem()
        {
            Item_listBox.Items.Clear();

            string[] tmp = FileIO.GetAllFiles(Act.Configuration.Control.Path.SavePath);


            for (int i = 0; i < tmp.Length; i++)
                Item_listBox.Items.Add( System.IO.Path.GetFileNameWithoutExtension(tmp[i]) );
        }
=======
            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b

        


            //Load item
            LoadItem();
        }


        private void New_button_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
            if(!Group.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SCLIP"))
            {
                SetupForm setupForm = new SetupForm();

                SetupForm.Switch(SetupForm.Channel.Welcome);

                setupForm.ShowDialog();
            }


            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();


            //Load item
            LoadItem();

            
        }

        private void Item_listBox_DoubleClick(object sender, EventArgs e)
        {
            Switch(Channel.Show);


            FileIO.Stream stream = new FileIO.Stream(Act.Configuration.Control.Path.SavePath + Item_listBox.SelectedItems[0],FileIO.Stream.FileMode.Read);

            string tmp = stream.Read();

            tmp = Act.GeneralPurpose.Cipher.Decrypt(Act.Configuration.Tmp.EncryptKey, tmp.Split(',')[1],tmp.Split(',')[0]);

            _showView.SET(tmp.Split(',')[0], tmp.Split(',')[1], tmp.Split(',')[2], tmp.Split(',')[3], tmp.Split(',')[4], tmp.Split(',')[5], tmp.Split(',')[6], tmp.Split(',')[6]);

            Switch(Channel.Show);
        }

        private void New_button_Click(object sender, EventArgs e)
        {
            View.Item.Control.EditMode = false;
            Switch(Channel.Control);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            View.Item.Control.EditMode = true;
            FileIO.Stream stream = new FileIO.Stream(Act.Configuration.Control.Path.SavePath + Item_listBox.SelectedItems[0], FileIO.Stream.FileMode.Read);

            string tmp = stream.Read();

            tmp = Act.GeneralPurpose.Cipher.Decrypt(Act.Configuration.Tmp.EncryptKey, tmp.Split(',')[1], tmp.Split(',')[0]);

            _controlView.SET(tmp.Split(',')[0], tmp.Split(',')[1], tmp.Split(',')[2], tmp.Split(',')[3], tmp.Split(',')[4], tmp.Split(',')[5], tmp.Split(',')[6], tmp.Split(',')[6]);
            Switch(Channel.Control);

            
        }

        private void Delete_button_Click(object sender, EventArgs e)
=======

        }

        private void Edit_button_Click(object sender, EventArgs e)
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
        {
            try
            {
                FileIO.Delete(Act.Configuration.Control.Path.SavePath + Item_listBox.SelectedItems[0]);
            }
            catch { }

            LoadItem();
            
        }

<<<<<<< HEAD
        private void Reload_button_Click(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.ShowDialog();
        }

    
=======
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

  
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
    }
}
