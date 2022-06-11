using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_CONTACT_TRACING
{
    public partial class GetPass : Form
    {
        public GetPass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\test.txt", true);
            file.WriteLine("Information of the persons :");
            file.WriteLine("First Name: " + FNTextBox1.Text);
            file.WriteLine("Surname: " + SNTextBox2.Text);
            file.WriteLine("Age: " + ATextBox3.Text);
            file.WriteLine("Phone Number: " + PNTextBox4.Text);
            file.WriteLine("Address: " + ADDTextBox5.Text);
            file.Close();
        }
    }
}
