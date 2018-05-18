﻿namespace Yggdrasil
{
    partial class Read_Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Read_Interface));
            this.ChapterNameText = new System.Windows.Forms.TextBox();
            this.BookContents = new System.Windows.Forms.TextBox();
            this.LastPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChapterNameText
            // 
            this.ChapterNameText.BackColor = System.Drawing.SystemColors.Menu;
            this.ChapterNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChapterNameText.Font = new System.Drawing.Font("华文中宋", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChapterNameText.Location = new System.Drawing.Point(12, 31);
            this.ChapterNameText.Multiline = true;
            this.ChapterNameText.Name = "ChapterNameText";
            this.ChapterNameText.ReadOnly = true;
            this.ChapterNameText.Size = new System.Drawing.Size(594, 54);
            this.ChapterNameText.TabIndex = 0;
            this.ChapterNameText.Text = "ChapterName";
            this.ChapterNameText.TextChanged += new System.EventHandler(this.ChapterName_TextChanged);
            // 
            // BookContents
            // 
            this.BookContents.Location = new System.Drawing.Point(22, 75);
            this.BookContents.Multiline = true;
            this.BookContents.Name = "BookContents";
            this.BookContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BookContents.Size = new System.Drawing.Size(639, 387);
            this.BookContents.TabIndex = 1;
            this.BookContents.Text = resources.GetString("BookContents.Text");
            this.BookContents.TextChanged += new System.EventHandler(this.Contents_TextChanged);
            // 
            // LastPage
            // 
            this.LastPage.Location = new System.Drawing.Point(115, 468);
            this.LastPage.Name = "LastPage";
            this.LastPage.Size = new System.Drawing.Size(101, 23);
            this.LastPage.TabIndex = 2;
            this.LastPage.Text = "Last page";
            this.LastPage.UseVisualStyleBackColor = true;
            this.LastPage.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextPage
            // 
            this.NextPage.Location = new System.Drawing.Point(447, 468);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(102, 23);
            this.NextPage.TabIndex = 3;
            this.NextPage.Text = "Next page";
            this.NextPage.UseVisualStyleBackColor = true;
            this.NextPage.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Read_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 501);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.LastPage);
            this.Controls.Add(this.BookContents);
            this.Controls.Add(this.ChapterNameText);
            this.Name = "Read_Interface";
            this.Text = "阅读界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChapterNameText;
        private System.Windows.Forms.TextBox BookContents;
        private System.Windows.Forms.Button LastPage;
        private System.Windows.Forms.Button NextPage;
    }
}