﻿
namespace DreamJoy_Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleRek = new System.Windows.Forms.Label();
            this.buttonRekPlus = new System.Windows.Forms.Button();
            this.buttonRekMin = new System.Windows.Forms.Button();
            this.labelRekToString = new System.Windows.Forms.Label();
            this.numRek = new System.Windows.Forms.NumericUpDown();
            this.numSpaar = new System.Windows.Forms.NumericUpDown();
            this.labelSpaarToString = new System.Windows.Forms.Label();
            this.buttonSpaarMin = new System.Windows.Forms.Button();
            this.buttonSpaarPlus = new System.Windows.Forms.Button();
            this.TitelSpaar = new System.Windows.Forms.Label();
            this.numZicht = new System.Windows.Forms.NumericUpDown();
            this.labelZichtToString = new System.Windows.Forms.Label();
            this.buttonZichtMin = new System.Windows.Forms.Button();
            this.buttonZichtPlus = new System.Windows.Forms.Button();
            this.TitelZicht = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpaar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZicht)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleRek
            // 
            this.TitleRek.AutoSize = true;
            this.TitleRek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleRek.Location = new System.Drawing.Point(78, 52);
            this.TitleRek.Name = "TitleRek";
            this.TitleRek.Size = new System.Drawing.Size(92, 25);
            this.TitleRek.TabIndex = 0;
            this.TitleRek.Text = "Rekening";
            // 
            // buttonRekPlus
            // 
            this.buttonRekPlus.Location = new System.Drawing.Point(334, 79);
            this.buttonRekPlus.Name = "buttonRekPlus";
            this.buttonRekPlus.Size = new System.Drawing.Size(112, 34);
            this.buttonRekPlus.TabIndex = 1;
            this.buttonRekPlus.Text = "+";
            this.buttonRekPlus.UseVisualStyleBackColor = true;
            this.buttonRekPlus.Click += new System.EventHandler(this.buttonRekPlus_Click);
            // 
            // buttonRekMin
            // 
            this.buttonRekMin.Location = new System.Drawing.Point(452, 79);
            this.buttonRekMin.Name = "buttonRekMin";
            this.buttonRekMin.Size = new System.Drawing.Size(112, 34);
            this.buttonRekMin.TabIndex = 3;
            this.buttonRekMin.Text = "-";
            this.buttonRekMin.UseVisualStyleBackColor = true;
            this.buttonRekMin.Click += new System.EventHandler(this.buttonRekMin_Click);
            // 
            // labelRekToString
            // 
            this.labelRekToString.AutoSize = true;
            this.labelRekToString.Location = new System.Drawing.Point(78, 115);
            this.labelRekToString.Name = "labelRekToString";
            this.labelRekToString.Size = new System.Drawing.Size(59, 25);
            this.labelRekToString.TabIndex = 4;
            this.labelRekToString.Text = "label2";
            // 
            // numRek
            // 
            this.numRek.Location = new System.Drawing.Point(78, 81);
            this.numRek.Name = "numRek";
            this.numRek.Size = new System.Drawing.Size(180, 31);
            this.numRek.TabIndex = 5;
            // 
            // numSpaar
            // 
            this.numSpaar.Location = new System.Drawing.Point(78, 208);
            this.numSpaar.Name = "numSpaar";
            this.numSpaar.Size = new System.Drawing.Size(180, 31);
            this.numSpaar.TabIndex = 10;
            // 
            // labelSpaarToString
            // 
            this.labelSpaarToString.AutoSize = true;
            this.labelSpaarToString.Location = new System.Drawing.Point(78, 242);
            this.labelSpaarToString.Name = "labelSpaarToString";
            this.labelSpaarToString.Size = new System.Drawing.Size(59, 25);
            this.labelSpaarToString.TabIndex = 9;
            this.labelSpaarToString.Text = "label2";
            // 
            // buttonSpaarMin
            // 
            this.buttonSpaarMin.Location = new System.Drawing.Point(452, 206);
            this.buttonSpaarMin.Name = "buttonSpaarMin";
            this.buttonSpaarMin.Size = new System.Drawing.Size(112, 34);
            this.buttonSpaarMin.TabIndex = 8;
            this.buttonSpaarMin.Text = "-";
            this.buttonSpaarMin.UseVisualStyleBackColor = true;
            this.buttonSpaarMin.Click += new System.EventHandler(this.buttonSpaarMin_Click);
            // 
            // buttonSpaarPlus
            // 
            this.buttonSpaarPlus.Location = new System.Drawing.Point(334, 206);
            this.buttonSpaarPlus.Name = "buttonSpaarPlus";
            this.buttonSpaarPlus.Size = new System.Drawing.Size(112, 34);
            this.buttonSpaarPlus.TabIndex = 7;
            this.buttonSpaarPlus.Text = "+";
            this.buttonSpaarPlus.UseVisualStyleBackColor = true;
            this.buttonSpaarPlus.Click += new System.EventHandler(this.buttonSpaarPlus_Click);
            // 
            // TitelSpaar
            // 
            this.TitelSpaar.AutoSize = true;
            this.TitelSpaar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitelSpaar.Location = new System.Drawing.Point(78, 179);
            this.TitelSpaar.Name = "TitelSpaar";
            this.TitelSpaar.Size = new System.Drawing.Size(135, 25);
            this.TitelSpaar.TabIndex = 6;
            this.TitelSpaar.Text = "Spaarrekening";
            // 
            // numZicht
            // 
            this.numZicht.Location = new System.Drawing.Point(78, 320);
            this.numZicht.Name = "numZicht";
            this.numZicht.Size = new System.Drawing.Size(180, 31);
            this.numZicht.TabIndex = 15;
            // 
            // labelZichtToString
            // 
            this.labelZichtToString.AutoSize = true;
            this.labelZichtToString.Location = new System.Drawing.Point(78, 354);
            this.labelZichtToString.Name = "labelZichtToString";
            this.labelZichtToString.Size = new System.Drawing.Size(59, 25);
            this.labelZichtToString.TabIndex = 14;
            this.labelZichtToString.Text = "label2";
            // 
            // buttonZichtMin
            // 
            this.buttonZichtMin.Location = new System.Drawing.Point(452, 318);
            this.buttonZichtMin.Name = "buttonZichtMin";
            this.buttonZichtMin.Size = new System.Drawing.Size(112, 34);
            this.buttonZichtMin.TabIndex = 13;
            this.buttonZichtMin.Text = "-";
            this.buttonZichtMin.UseVisualStyleBackColor = true;
            this.buttonZichtMin.Click += new System.EventHandler(this.buttonZichtMin_Click);
            // 
            // buttonZichtPlus
            // 
            this.buttonZichtPlus.Location = new System.Drawing.Point(334, 318);
            this.buttonZichtPlus.Name = "buttonZichtPlus";
            this.buttonZichtPlus.Size = new System.Drawing.Size(112, 34);
            this.buttonZichtPlus.TabIndex = 12;
            this.buttonZichtPlus.Text = "+";
            this.buttonZichtPlus.UseVisualStyleBackColor = true;
            this.buttonZichtPlus.Click += new System.EventHandler(this.buttonZichtPlus_Click);
            // 
            // TitelZicht
            // 
            this.TitelZicht.AutoSize = true;
            this.TitelZicht.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitelZicht.Location = new System.Drawing.Point(78, 291);
            this.TitelZicht.Name = "TitelZicht";
            this.TitelZicht.Size = new System.Drawing.Size(130, 25);
            this.TitelZicht.TabIndex = 11;
            this.TitelZicht.Text = "Zichtrekening";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numZicht);
            this.Controls.Add(this.labelZichtToString);
            this.Controls.Add(this.buttonZichtMin);
            this.Controls.Add(this.buttonZichtPlus);
            this.Controls.Add(this.TitelZicht);
            this.Controls.Add(this.numSpaar);
            this.Controls.Add(this.labelSpaarToString);
            this.Controls.Add(this.buttonSpaarMin);
            this.Controls.Add(this.buttonSpaarPlus);
            this.Controls.Add(this.TitelSpaar);
            this.Controls.Add(this.numRek);
            this.Controls.Add(this.labelRekToString);
            this.Controls.Add(this.buttonRekMin);
            this.Controls.Add(this.buttonRekPlus);
            this.Controls.Add(this.TitleRek);
            this.Name = "Form1";
            this.Text = "Acount Manager";
            ((System.ComponentModel.ISupportInitialize)(this.numRek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpaar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleRek;
        private System.Windows.Forms.Button buttonRekPlus;
        private System.Windows.Forms.Button buttonRekMin;
        private System.Windows.Forms.Label labelRekToString;
        private System.Windows.Forms.NumericUpDown numRek;
        private System.Windows.Forms.NumericUpDown numSpaar;
        private System.Windows.Forms.Label labelSpaarToString;
        private System.Windows.Forms.Button buttonSpaarMin;
        private System.Windows.Forms.Button buttonSpaarPlus;
        private System.Windows.Forms.Label TitelSpaar;
        private System.Windows.Forms.NumericUpDown numZicht;
        private System.Windows.Forms.Label labelZichtToString;
        private System.Windows.Forms.Button buttonZichtMin;
        private System.Windows.Forms.Button buttonZichtPlus;
        private System.Windows.Forms.Label TitelZicht;
    }
}

