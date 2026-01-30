using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSenSoutenance.View;
using AppSenSoutenance.View.Parametre;
using Microsoft.VisualBasic.Devices;

namespace AppSenSoutenance
{
    public partial class frmMDI : Form
    {
        //Declaration des variables
        private Button currentButton;
        private Form activateForm;
        private int tempIndex;
        private Random random;
        private Form activaForm;
        public frmMDI()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Methode permettant de fermer tout les forms
        /// </summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }
        //Methode pour se deconnecte 
        private void seDeconnecteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        
        
      
        //Methode pour accede au form professeur
        
        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0 , 0);
        }

        private  void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(38, 101, 140);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm , object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnQuitte_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Parametre.frmSession(), sender);
        }

        private void btnAnnéeAcademique_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Parametre.frmAnneeAcademique(), sender);
        }

        private void btnDepartement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Parametre.frmDepartement(), sender); 
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSoutenance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Parametre.frmSoutenance(), sender);
        }
    }
}
