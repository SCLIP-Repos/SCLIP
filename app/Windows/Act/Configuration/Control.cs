﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace SCLIP.Act.Configuration
=======
namespace $safeprojectname$.Act.Configuration
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
{
    partial class Control
    {

        internal void Save(string Str,Enum Target)
        {
            switch(Target)
            {
                case TargetChannel.LoginKey:
                    Keys.Default.Login = Str;
                    Keys.Default.Save();
                    break;


                case TargetChannel.LoginIv:
                    IVs.Default.Login = Str;
                    IVs.Default.Save();
                    break;


                case TargetChannel.LoginSalt:
                    Salts.Default.Login = Str;
                    Salts.Default.Save();
                    break;

                case TargetChannel.EncryptKey:
                    Keys.Default.Encrypt = Str;
                    Keys.Default.Save();
                    break;

            }

        }

        internal string Load(Enum Target)
        {

            switch (Target)
            {
                case TargetChannel.LoginKey:
                    return Keys.Default.Login;

                case TargetChannel.LoginIv:
                    return IVs.Default.Login;


                case TargetChannel.LoginSalt:
                    return Salts.Default.Login;


                case TargetChannel.EncryptKey:
                    return Keys.Default.Encrypt;
                default:
                    return null;

            }
        }


        internal class Path
        {
<<<<<<< HEAD
            internal static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SCLIP\";
=======
            internal static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\$safeprojectname$\";
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
        }
    }
}
