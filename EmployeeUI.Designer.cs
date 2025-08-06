namespace ProjektiTI_CallCenter
{
    partial class EmployeeUI
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
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(59, 242);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(261, 119);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Call";
            this.metroTile4.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_phone;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile4_MouseClick);
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Location = new System.Drawing.Point(410, 242);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(261, 119);
            this.tileLogout.TabIndex = 2;
            this.tileLogout.Text = "Logout";
            this.tileLogout.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_door_leave;
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileLogout.UseSelectable = true;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tileLogout_MouseClick);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(410, 89);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(261, 122);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Chat";
            this.metroTile2.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_chat;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile2_MouseClick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(59, 89);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(261, 121);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Profili juaj";
            this.metroTile1.TileImage = global::ProjektiTI_CallCenter.Properties.Resources.appbar_people;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseClick);
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "EmployeeUI";
            this.Text = "Paneli i Agjentit Telefonik";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile tileLogout;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}