﻿namespace cSharpSumFactorialFibonnaci
{
    partial class FrmSumFibFac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSumFibFac));
            this.LblLen = new System.Windows.Forms.Label();
            this.TxtFactorial = new System.Windows.Forms.TextBox();
            this.TxtFibonacci = new System.Windows.Forms.TextBox();
            this.TxtSum = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtLen = new System.Windows.Forms.TextBox();
            this.LblFactorial = new System.Windows.Forms.Label();
            this.LblFibonacci = new System.Windows.Forms.Label();
            this.Lbl02 = new System.Windows.Forms.Label();
            this.Lbl01 = new System.Windows.Forms.Label();
            this.LblN = new System.Windows.Forms.Label();
            this.LblSum = new System.Windows.Forms.Label();
            this.CbxFibonnaci = new System.Windows.Forms.ComboBox();
            this.TxtPrime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblLen
            // 
            this.LblLen.AutoSize = true;
            this.LblLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLen.Location = new System.Drawing.Point(261, 6);
            this.LblLen.Name = "LblLen";
            this.LblLen.Size = new System.Drawing.Size(146, 24);
            this.LblLen.TabIndex = 24;
            this.LblLen.Text = "Length of Series";
            // 
            // TxtFactorial
            // 
            this.TxtFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactorial.Location = new System.Drawing.Point(457, 225);
            this.TxtFactorial.Name = "TxtFactorial";
            this.TxtFactorial.ReadOnly = true;
            this.TxtFactorial.Size = new System.Drawing.Size(200, 31);
            this.TxtFactorial.TabIndex = 23;
            this.TxtFactorial.Text = "1234567890123456";
            this.TxtFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFibonacci
            // 
            this.TxtFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFibonacci.Location = new System.Drawing.Point(234, 225);
            this.TxtFibonacci.Name = "TxtFibonacci";
            this.TxtFibonacci.ReadOnly = true;
            this.TxtFibonacci.Size = new System.Drawing.Size(200, 31);
            this.TxtFibonacci.TabIndex = 22;
            this.TxtFibonacci.Text = "1234567890123456";
            this.TxtFibonacci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSum
            // 
            this.TxtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSum.Location = new System.Drawing.Point(11, 225);
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.ReadOnly = true;
            this.TxtSum.Size = new System.Drawing.Size(200, 31);
            this.TxtSum.TabIndex = 21;
            this.TxtSum.Text = "1234567890123456";
            this.TxtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCalculate.Location = new System.Drawing.Point(239, 296);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(190, 58);
            this.BtnCalculate.TabIndex = 20;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtLen
            // 
            this.TxtLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLen.Location = new System.Drawing.Point(263, 38);
            this.TxtLen.Name = "TxtLen";
            this.TxtLen.Size = new System.Drawing.Size(142, 44);
            this.TxtLen.TabIndex = 19;
            this.TxtLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLen.TextChanged += new System.EventHandler(this.TxtLen_TextChanged);
            this.TxtLen.DoubleClick += new System.EventHandler(this.TxtLen_DoubleClick);
            // 
            // LblFactorial
            // 
            this.LblFactorial.AutoSize = true;
            this.LblFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactorial.Location = new System.Drawing.Point(514, 101);
            this.LblFactorial.Name = "LblFactorial";
            this.LblFactorial.Size = new System.Drawing.Size(86, 73);
            this.LblFactorial.TabIndex = 18;
            this.LblFactorial.Text = "n!";
            // 
            // LblFibonacci
            // 
            this.LblFibonacci.AutoSize = true;
            this.LblFibonacci.Font = new System.Drawing.Font("Symbol", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblFibonacci.Location = new System.Drawing.Point(280, 61);
            this.LblFibonacci.Name = "LblFibonacci";
            this.LblFibonacci.Size = new System.Drawing.Size(108, 118);
            this.LblFibonacci.TabIndex = 17;
            this.LblFibonacci.Text = "j";
            // 
            // Lbl02
            // 
            this.Lbl02.AutoSize = true;
            this.Lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl02.Location = new System.Drawing.Point(126, 122);
            this.Lbl02.Name = "Lbl02";
            this.Lbl02.Size = new System.Drawing.Size(20, 31);
            this.Lbl02.TabIndex = 16;
            this.Lbl02.Text = "i";
            // 
            // Lbl01
            // 
            this.Lbl01.AutoSize = true;
            this.Lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl01.Location = new System.Drawing.Point(85, 173);
            this.Lbl01.Name = "Lbl01";
            this.Lbl01.Size = new System.Drawing.Size(51, 31);
            this.Lbl01.TabIndex = 15;
            this.Lbl01.Text = "i=1";
            // 
            // LblN
            // 
            this.LblN.AutoSize = true;
            this.LblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN.Location = new System.Drawing.Point(95, 73);
            this.LblN.Name = "LblN";
            this.LblN.Size = new System.Drawing.Size(29, 31);
            this.LblN.TabIndex = 14;
            this.LblN.Text = "n";
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.Font = new System.Drawing.Font("Symbol", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblSum.Location = new System.Drawing.Point(60, 74);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(109, 118);
            this.LblSum.TabIndex = 13;
            this.LblSum.Text = "S";
            // 
            // CbxFibonnaci
            // 
            this.CbxFibonnaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFibonnaci.FormattingEnabled = true;
            this.CbxFibonnaci.Location = new System.Drawing.Point(227, 186);
            this.CbxFibonnaci.Name = "CbxFibonnaci";
            this.CbxFibonnaci.Size = new System.Drawing.Size(215, 33);
            this.CbxFibonnaci.TabIndex = 25;
            // 
            // TxtPrime
            // 
            this.TxtPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrime.Location = new System.Drawing.Point(11, 329);
            this.TxtPrime.Name = "TxtPrime";
            this.TxtPrime.ReadOnly = true;
            this.TxtPrime.Size = new System.Drawing.Size(200, 31);
            this.TxtPrime.TabIndex = 26;
            this.TxtPrime.Text = "Prime - ???";
            this.TxtPrime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 73);
            this.label1.TabIndex = 27;
            this.label1.Text = "n\'";
            // 
            // FrmSumFibFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 366);
            this.Controls.Add(this.TxtPrime);
            this.Controls.Add(this.CbxFibonnaci);
            this.Controls.Add(this.LblLen);
            this.Controls.Add(this.TxtFactorial);
            this.Controls.Add(this.TxtFibonacci);
            this.Controls.Add(this.TxtSum);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtLen);
            this.Controls.Add(this.LblFactorial);
            this.Controls.Add(this.LblFibonacci);
            this.Controls.Add(this.Lbl02);
            this.Controls.Add(this.Lbl01);
            this.Controls.Add(this.LblN);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(685, 405);
            this.MinimumSize = new System.Drawing.Size(685, 405);
            this.Name = "FrmSumFibFac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Common Mathematical Series by Jwf";
            this.Load += new System.EventHandler(this.FrmSumFibFac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblLen;
        internal System.Windows.Forms.TextBox TxtFactorial;
        internal System.Windows.Forms.TextBox TxtFibonacci;
        internal System.Windows.Forms.TextBox TxtSum;
        internal System.Windows.Forms.Button BtnCalculate;
        internal System.Windows.Forms.TextBox TxtLen;
        internal System.Windows.Forms.Label LblFactorial;
        internal System.Windows.Forms.Label LblFibonacci;
        internal System.Windows.Forms.Label Lbl02;
        internal System.Windows.Forms.Label Lbl01;
        internal System.Windows.Forms.Label LblN;
        internal System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.ComboBox CbxFibonnaci;
        internal System.Windows.Forms.TextBox TxtPrime;
        internal System.Windows.Forms.Label label1;
    }
}

