namespace AppSenSoutenance
{
    partial class frmMDI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.btnDepartement = new System.Windows.Forms.Button();
            this.btnAnnéeAcademique = new System.Windows.Forms.Button();
            this.btnMemoire = new System.Windows.Forms.Button();
            this.btnSoutenance = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDesktopPane);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 724);
            this.panel1.TabIndex = 3;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(345, 70);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(842, 654);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.panelMenu.Controls.Add(this.btnUtilisateur);
            this.panelMenu.Controls.Add(this.btnDepartement);
            this.panelMenu.Controls.Add(this.btnAnnéeAcademique);
            this.panelMenu.Controls.Add(this.btnMemoire);
            this.panelMenu.Controls.Add(this.btnSoutenance);
            this.panelMenu.Controls.Add(this.btnSession);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(345, 654);
            this.panelMenu.TabIndex = 1;
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnUtilisateur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUtilisateur.Location = new System.Drawing.Point(23, 518);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(288, 64);
            this.btnUtilisateur.TabIndex = 9;
            this.btnUtilisateur.Text = " Utilisateur";
            this.btnUtilisateur.UseVisualStyleBackColor = false;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // btnDepartement
            // 
            this.btnDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnDepartement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepartement.Location = new System.Drawing.Point(23, 423);
            this.btnDepartement.Name = "btnDepartement";
            this.btnDepartement.Size = new System.Drawing.Size(288, 64);
            this.btnDepartement.TabIndex = 8;
            this.btnDepartement.Text = "Département";
            this.btnDepartement.UseVisualStyleBackColor = false;
            this.btnDepartement.Click += new System.EventHandler(this.btnDepartement_Click);
            // 
            // btnAnnéeAcademique
            // 
            this.btnAnnéeAcademique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnAnnéeAcademique.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnéeAcademique.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnéeAcademique.Location = new System.Drawing.Point(23, 155);
            this.btnAnnéeAcademique.Name = "btnAnnéeAcademique";
            this.btnAnnéeAcademique.Size = new System.Drawing.Size(288, 64);
            this.btnAnnéeAcademique.TabIndex = 7;
            this.btnAnnéeAcademique.Text = "Année Academique";
            this.btnAnnéeAcademique.UseVisualStyleBackColor = false;
            this.btnAnnéeAcademique.Click += new System.EventHandler(this.btnAnnéeAcademique_Click);
            // 
            // btnMemoire
            // 
            this.btnMemoire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnMemoire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemoire.Location = new System.Drawing.Point(23, 241);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Size = new System.Drawing.Size(288, 64);
            this.btnMemoire.TabIndex = 6;
            this.btnMemoire.Text = "Mémoire";
            this.btnMemoire.UseVisualStyleBackColor = false;
            // 
            // btnSoutenance
            // 
            this.btnSoutenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnSoutenance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoutenance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSoutenance.Location = new System.Drawing.Point(23, 332);
            this.btnSoutenance.Name = "btnSoutenance";
            this.btnSoutenance.Size = new System.Drawing.Size(288, 64);
            this.btnSoutenance.TabIndex = 5;
            this.btnSoutenance.Text = "Soutenance";
            this.btnSoutenance.UseVisualStyleBackColor = false;
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.btnSession.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSession.Location = new System.Drawing.Point(23, 66);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(288, 64);
            this.btnSession.TabIndex = 4;
            this.btnSession.Text = "Session";
            this.btnSession.UseVisualStyleBackColor = false;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnQuitte);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 70);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSenSoutenance.Properties.Resources.etudiant_60;
            this.pictureBox1.Location = new System.Drawing.Point(78, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 98);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitte
            // 
            this.btnQuitte.Location = new System.Drawing.Point(1119, 24);
            this.btnQuitte.Name = "btnQuitte";
            this.btnQuitte.Size = new System.Drawing.Size(56, 35);
            this.btnQuitte.TabIndex = 8;
            this.btnQuitte.Text = "X";
            this.btnQuitte.UseVisualStyleBackColor = true;
            this.btnQuitte.Click += new System.EventHandler(this.btnQuitte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(162, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENSOUTENANCE";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1187, 724);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "Sen Soutenance::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnQuitte;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnDepartement;
        private System.Windows.Forms.Button btnAnnéeAcademique;
        private System.Windows.Forms.Button btnMemoire;
        private System.Windows.Forms.Button btnSoutenance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}