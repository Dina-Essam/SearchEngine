﻿namespace SearchEngineFile
{
    partial class KeywordsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeywordsDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.detailsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "category";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(99, 26);
            this.category.Margin = new System.Windows.Forms.Padding(2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(110, 21);
            this.category.TabIndex = 11;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(12, 62);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(475, 245);
            this.detailsTextBox.TabIndex = 19;
            this.detailsTextBox.Text = "";
            // 
            // KeywordsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 363);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeywordsDetails";
            this.Text = "KeywordsDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.RichTextBox detailsTextBox;
    }
}