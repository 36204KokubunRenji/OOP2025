﻿namespace UnitComverter {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            tbBeforeConversion = new TextBox();
            tbAfterConversion = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "距離換算アプリ";
            // 
            // tbBeforeConversion
            // 
            tbBeforeConversion.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbBeforeConversion.Location = new Point(108, 63);
            tbBeforeConversion.Name = "tbBeforeConversion";
            tbBeforeConversion.Size = new Size(125, 39);
            tbBeforeConversion.TabIndex = 1;
            tbBeforeConversion.Text = "150";
            tbBeforeConversion.TextChanged += tbBeforeConversion_TextChanged;
            // 
            // tbAfterConversion
            // 
            tbAfterConversion.Location = new Point(108, 246);
            tbAfterConversion.Name = "tbAfterConversion";
            tbAfterConversion.Size = new Size(125, 23);
            tbAfterConversion.TabIndex = 2;
            tbAfterConversion.TextChanged += tbAfterConversion_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(108, 142);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 3;
            button1.Text = "変換";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ConvertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 329);
            Controls.Add(button1);
            Controls.Add(tbAfterConversion);
            Controls.Add(tbBeforeConversion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbBeforeConversion;
        private TextBox tbAfterConversion;
        private Button button1;
    }
}
