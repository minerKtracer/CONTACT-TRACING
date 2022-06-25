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
            var Month = MTextBox14.Text;
            var Day = DTextBox15.Text;
            var Year = YTextBox16.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\" + (Month) + " " + (Day) + ", " + (Year) + " date.txt", true);
            file.WriteLine("Information of the person :");
            file.WriteLine("Date : " + MTextBox14.Text + " " + DTextBox15.Text + " " + YTextBox16.Text);
            file.WriteLine("Time in (am/pm): " + TITextBox2.Text);
            file.WriteLine("First Name: " + FNTextBox3.Text);
            file.WriteLine("Surname: " + SNTextBox4.Text);
            file.WriteLine("Age: " + ATextBox5.Text);
            file.WriteLine("Sex (F/M): " + STextBox6.Text);
            file.WriteLine("Phone Number: " + PNTextBox7.Text);
            file.WriteLine("Address: " + ADDTextBox8.Text);
            file.WriteLine("Baranagy: " + BTextBox9.Text);
            file.WriteLine("City: " + CTextBox10.Text);
            file.WriteLine("Expossure Risk: " + ERTextBox11.Text);
            file.WriteLine("Vaccinated (Y/N): " + VTextBox12.Text);
            file.WriteLine("How many dose?: " + QTextBox13.Text);
            file.Close();

            MessageBox.Show("Done");
        
        }

        private void AboutSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kylene Shane M. Varona from BSCOE 1-5", "BASIC INFO");
        }

        private void ExitTab_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void ReadHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void SButton2_Click(object sender, EventArgs e)
        {
            var date = SDtextBox17.Text;

            StreamReader reader = new StreamReader(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\" + (date) + " date.txt");
            String file = reader.ReadToEnd();
            MessageBox.Show(file);

            //while (date < file.Length && !reader.EndOfStream)
            //{
            //    String line = reader.ReadLine(); index++;
            //    MessageBox.Show(line);
            //}
            
        }

        private void RButton3_Click(object sender, EventArgs e)
        {
            if (MTextBox14.Text != string.Empty || DTextBox15.Text != string.Empty || YTextBox16.Text != string.Empty || TITextBox2.Text != string.Empty || FNTextBox3.Text != string.Empty || SNTextBox4.Text != string.Empty || ATextBox5.Text != string.Empty || STextBox6.Text != string.Empty || PNTextBox7.Text != string.Empty || ADDTextBox8.Text != string.Empty || BTextBox9.Text != string.Empty || CTextBox10.Text != string.Empty || ERTextBox11.Text != string.Empty || QTextBox13.Text != string.Empty)
            {
                MTextBox14.Text = "";
                DTextBox15.Text = "";
                YTextBox16.Text = "";
                TITextBox2.Text = "";
                FNTextBox3.Text = "";
                SNTextBox4.Text = "";
                ATextBox5.Text = "";
                STextBox6.Text = "";
                PNTextBox7.Text = "";
                ADDTextBox8.Text = "";
                BTextBox9.Text = "";
                CTextBox10.Text = "";
                ERTextBox11.Text = "";
                VTextBox12.Text = "";
                QTextBox13.Text = "";
            }
        }
    }
}
