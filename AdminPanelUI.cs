using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProjektiTI_CallCenter
{
    public partial class AdminPanelUI : MetroForm
    {
        public AdminPanelUI()
        {
            InitializeComponent();
        }

        private void metroTile2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            UserList UL = new UserList();
            UL.ShowDialog();
            this.Close();
        }

        private void buttonAssignProject_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AssignProject ap = new AssignProject();
            ap.ShowDialog();
            this.Close();
        }

        private void tileViewProfile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewProfileUI rr = new ViewProfileUI();
            rr.ShowDialog();
            this.Close();
        }

        private void tileLogout_MouseClick(object sender, MouseEventArgs e)
        {
            LoginUI.userlogged = "";
            this.Hide();
            LoginUI login = new LoginUI();
            login.ShowDialog();
            this.Close();
        }

        private void tileChat_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Chat ch = new Chat();
            ch.ShowDialog();
            this.Close();
        }

        private void tileRecorded_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Recorded_Conversations ss = new Recorded_Conversations();
            ss.ShowDialog();
            this.Close();
        }

        private void metroTile4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            View_Report vr = new View_Report();
            vr.ShowDialog();
            this.Close();
        }
    }
}
