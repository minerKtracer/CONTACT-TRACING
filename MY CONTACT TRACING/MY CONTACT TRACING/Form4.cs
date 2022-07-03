﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_CONTACT_TRACING
{
    public partial class QRHome : Form
    {
        public QRHome()
        {
            InitializeComponent();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPage SP = new SignUpPage();
            SP.ShowDialog(); // Shows SignUpPage

            this.Show();
        }

        private void BTNDirect_Click(object sender, EventArgs e)
        {
            this.Hide();
            QRcodepass Qp = new QRcodepass();
            Qp.ShowDialog(); // Shows QRcodepass

            this.Show();
        }
    }
}
