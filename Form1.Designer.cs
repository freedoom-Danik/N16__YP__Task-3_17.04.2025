﻿namespace N16__YP__Task_3_17._04._2025
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400); // Размер формы
            this.DoubleBuffered = true; // Убираем мерцание при анимации
            this.Name = "Form1";
            this.Text = "Анимация по синусоиде";
            this.ResumeLayout(false);
        }
    }
}