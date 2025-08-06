namespace ProjektiTI_CallCenter
{
    partial class CustomerUI
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
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tileViewProfile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Location = new System.Drawing.Point(386, 263);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(222, 135);
            this.tileLogout.TabIndex = 3;
            this.tileLogout.Text = "LogOut";
            this.tileLogout.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_door_leave;
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileLogout.UseSelectable = true;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileLogout_MouseClick);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(48, 263);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(224, 135);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Shikoj Projektet tua";
            this.metroTile3.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_edit_box;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile3_MouseClick);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(386, 76);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(222, 138);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Shto Projekt";
            this.metroTile2.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_add;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile2_MouseClick);
            // 
            // tileViewProfile
            // 
            this.tileViewProfile.ActiveControl = null;
            this.tileViewProfile.Location = new System.Drawing.Point(48, 76);
            this.tileViewProfile.Name = "tileViewProfile";
            this.tileViewProfile.Size = new System.Drawing.Size(224, 138);
            this.tileViewProfile.TabIndex = 0;
            this.tileViewProfile.Text = "Profili Juaj";
            this.tileViewProfile.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar1;
            this.tileViewProfile.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileViewProfile.UseSelectable = true;
            this.tileViewProfile.UseTileImage = true;
            this.tileViewProfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileViewProfile_MouseClick);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tileViewProfile);
            this.Name = "CustomerUI";
            this.Text = "Paneli i Konsumatorit";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileViewProfile;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile tileLogout;
    }
}