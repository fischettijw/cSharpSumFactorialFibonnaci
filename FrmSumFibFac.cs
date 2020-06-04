﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpSumFactorialFibonnaci
{
    public partial class FrmSumFibFac : Form
    {
        public FrmSumFibFac()
        {
            InitializeComponent();
        }

        private void FrmSumFibFac_Load(object sender, EventArgs e)
        {
            TxtLen.Text = "10";
            CbxFibonnaci.DropDownStyle = ComboBoxStyle.DropDownList;    // DropDownList makes it ReadOnly
            this.AcceptButton = BtnCalculate;
            BtnCalculate.PerformClick();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            TxtSum.Text = SumSeries(int.Parse(TxtLen.Text)).ToString();
            TxtFibonacci.Text = FibonnacciSeries(int.Parse(TxtLen.Text)).ToString();
            TxtFactorial.Text = FactorialSeries(int.Parse(TxtLen.Text)).ToString("E9");
        }

        public int SumSeries(int n)
        {
            int seriesSum = 0;
            for (int i = 1; i <= n; i++)
            {
                seriesSum += i;
            }
            return seriesSum;
        }

        public Int32 FibonnacciSeries(int n)
        {
            Int32 fib = 0;
            Int32 a, b = 1;
            if (n < 3) return 1;
            a = b = 1;
            CbxFibonnaci.Items.Clear();
            CbxFibonnaci.Items.Add($"  {"01"}   {"0000000001"}");
            CbxFibonnaci.Items.Add($"  {"02"}   {"0000000001"}");
            try
            {
                for (int i = 3; i <= n; i++)
                {
                    fib = a + b;
                    if (fib < 0) { fib = -1; break; };
                    CbxFibonnaci.Items.Add($"  {i.ToString("D2")}   {fib.ToString("D10")}");
                    a = b;
                    b = fib;
                }
            }
            catch (Exception)
            {
                fib = -1;
            }
            return fib;
        }

        public Double FactorialSeries(int n)
        {
            Double fac = 1;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    fac *= i;
                }
            }
            catch (Exception)
            {
                fac = -1;
            }
            return fac;
        }

        private void TxtLen_TextChanged(object sender, EventArgs e)
        {
            CbxFibonnaci.Items.Clear();
            TxtSum.Text = "";
            TxtFibonacci.Text = "";
            TxtFactorial.Text = "";
        }
    }
}
