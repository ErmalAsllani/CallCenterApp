using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiTI_CallCenter
{
    public partial class Registration : MetroForm
    {
        public static int priority = 0;
        public Registration()
        {
            InitializeComponent();
        }


        private void metroTextBox1_MouseHover(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
        }

        private void metroTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            metroTextBox1.Text = "";
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String var = metroComboBox1.Text;
            if (var == "Admin")
            {
                priority = 1;
                metroTextBox1.Visible = true;
                metroButton3.Visible = true;
            }
            else if (var == "Puntor" || var == "Konsumator")
            {
                if (var == "Puntor")
                {
                    priority = 2;
                }
                else priority = 3;

                this.Hide();

                RegistrationUI frm = new RegistrationUI();
                frm.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Ju lutem selektoni nje opsion!");
        }

        private void metroButton3_MouseClick(object sender, MouseEventArgs e)
        {
            string admincheck = metroTextBox1.Text;
            if (admincheck == "007")
            {
                this.Hide();

                RegistrationUI frm = new RegistrationUI();
                frm.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Passwordi juaj eshte Invalid");
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LoginUI ui = new LoginUI();
            ui.ShowDialog();
            this.Close();
        }
    }
}
