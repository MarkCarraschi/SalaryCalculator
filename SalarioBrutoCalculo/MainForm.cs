﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioBrutoCalculo
{
    public partial class mainFormCalculatorSalaryBruto : Form
    {
        public mainFormCalculatorSalaryBruto(){
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e){

            txtSalarioBruto.Clear();
            txtTransportBack.Clear();
            txtTransportGo.Clear();
            txtTransportTotal.Clear();

        }

        private void mainFormCalculatorSalaryBruto_Load(object sender, EventArgs e){
            //Set disable components

        }
    }
}
