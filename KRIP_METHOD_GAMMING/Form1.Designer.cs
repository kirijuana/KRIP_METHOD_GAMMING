﻿namespace KRIP_METHOD_GAMMING
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShifrText = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.button_unShifr = new System.Windows.Forms.Button();
            this.button_Shifr = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShifrText
            // 
            this.ShifrText.Location = new System.Drawing.Point(196, 305);
            this.ShifrText.Name = "ShifrText";
            this.ShifrText.Size = new System.Drawing.Size(456, 20);
            this.ShifrText.TabIndex = 14;
            this.ShifrText.TextChanged += new System.EventHandler(this.ShifrText_TextChanged);
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(196, 125);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(456, 20);
            this.Text.TabIndex = 13;
            this.Text.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 211);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(325, 20);
            this.keyBox.TabIndex = 12;
            this.keyBox.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // button_unShifr
            // 
            this.button_unShifr.Location = new System.Drawing.Point(371, 232);
            this.button_unShifr.Name = "button_unShifr";
            this.button_unShifr.Size = new System.Drawing.Size(124, 23);
            this.button_unShifr.TabIndex = 11;
            this.button_unShifr.Text = "Расшифровать";
            this.button_unShifr.UseVisualStyleBackColor = true;
            this.button_unShifr.Click += new System.EventHandler(this.button_unShifr_Click);
            // 
            // button_Shifr
            // 
            this.button_Shifr.Location = new System.Drawing.Point(371, 189);
            this.button_Shifr.Name = "button_Shifr";
            this.button_Shifr.Size = new System.Drawing.Size(124, 23);
            this.button_Shifr.TabIndex = 10;
            this.button_Shifr.Text = "Зашифровать";
            this.button_Shifr.UseVisualStyleBackColor = true;
            this.button_Shifr.Click += new System.EventHandler(this.button_Shifr_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(520, 235);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(89, 20);
            this.textBoxB.TabIndex = 15;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(520, 189);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(89, 20);
            this.textBoxA.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 537);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.ShifrText);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.button_unShifr);
            this.Controls.Add(this.button_Shifr);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShifrText;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button button_unShifr;
        private System.Windows.Forms.Button button_Shifr;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
    }
}

