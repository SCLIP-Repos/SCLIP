﻿namespace SCLIP.View.SetupForm
{
    partial class Passwd
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Psw_textBox = new System.Windows.Forms.TextBox();
            this.RePsw_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PswLevel_progressBar = new System.Windows.Forms.ProgressBar();
            this.PswLevel_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Psw_textBox
            // 
            this.Psw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Psw_textBox.Location = new System.Drawing.Point(129, 85);
            this.Psw_textBox.Name = "Psw_textBox";
            this.Psw_textBox.Size = new System.Drawing.Size(338, 23);
            this.Psw_textBox.TabIndex = 1;
            this.Psw_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RePsw_textBox
            // 
            this.RePsw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.RePsw_textBox.Location = new System.Drawing.Point(129, 139);
            this.RePsw_textBox.Name = "RePsw_textBox";
            this.RePsw_textBox.Size = new System.Drawing.Size(338, 23);
            this.RePsw_textBox.TabIndex = 2;
            this.RePsw_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // Back_button
            // 
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(310, 456);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(92, 28);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "←";
            this.Back_button.UseVisualStyleBackColor = true;
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(408, 456);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(92, 28);
            this.Next_button.TabIndex = 6;
            this.Next_button.Text = "→";
            this.Next_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(51, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Re enter";
            // 
            // PswLevel_progressBar
            // 
            this.PswLevel_progressBar.Location = new System.Drawing.Point(46, 194);
            this.PswLevel_progressBar.Name = "PswLevel_progressBar";
            this.PswLevel_progressBar.Size = new System.Drawing.Size(421, 17);
            this.PswLevel_progressBar.TabIndex = 9;
            // 
            // PswLevel_label
            // 
            this.PswLevel_label.AutoSize = true;
            this.PswLevel_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.PswLevel_label.Location = new System.Drawing.Point(44, 219);
            this.PswLevel_label.Name = "PswLevel_label";
            this.PswLevel_label.Size = new System.Drawing.Size(35, 12);
            this.PswLevel_label.TabIndex = 10;
            this.PswLevel_label.Text = "label3";
            // 
            // Passwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PswLevel_label);
            this.Controls.Add(this.PswLevel_progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RePsw_textBox);
            this.Controls.Add(this.Psw_textBox);
            this.Name = "Passwd";
            this.Size = new System.Drawing.Size(503, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Psw_textBox;
        private System.Windows.Forms.TextBox RePsw_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PswLevel_progressBar;
        private System.Windows.Forms.Label PswLevel_label;
    }
}
