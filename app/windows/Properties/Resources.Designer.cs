﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCLIP.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SCLIP.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Only available when you agree with License. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string agree_Alert {
            get {
                return ResourceManager.GetString("agree_Alert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The password is incorrect. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string login_Failure {
            get {
                return ResourceManager.GetString("login_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Login processing could not be completed normally due to internal error. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string login_Failure_SysErr {
            get {
                return ResourceManager.GetString("login_Failure_SysErr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Password must be 5 digits or more. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string passwod_NoLength {
            get {
                return ResourceManager.GetString("passwod_NoLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   It does not match the confirmation input. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string password_NoConfirmation {
            get {
                return ResourceManager.GetString("password_NoConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Little nice に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string password_Strength_LittleNice {
            get {
                return ResourceManager.GetString("password_Strength_LittleNice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Strong に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string password_Strength_Strong {
            get {
                return ResourceManager.GetString("password_Strength_Strong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Weak に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string password_Strength_Weak {
            get {
                return ResourceManager.GetString("password_Strength_Weak", resourceCulture);
            }
        }
    }
}
