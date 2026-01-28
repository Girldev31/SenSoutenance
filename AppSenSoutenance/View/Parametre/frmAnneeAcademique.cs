using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            dgAnneeAcademique.DataSource = db.anneeAcademiques.ToList();
            dgAnneeAcademique.Columns["IdAnneAcademique"].Visible = false;
        }

        public void Effacer()
        {
            txtText.Clear();
            txtValeur.Clear();
            dgAnneeAcademique.DataSource = db.anneeAcademiques.ToList();
            txtText.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AnneeAcademique anneeAcademique = new AnneeAcademique()
            {
                LibelleAnneAcademique = txtText.Text,
                AnneAcademiqueVal = int.Parse(txtValeur.Text)
            };
            db.anneeAcademiques.Add(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.anneeAcademiques.Find(id);
            anneeAcademique.LibelleAnneAcademique = txtText.Text;
            anneeAcademique.AnneAcademiqueVal = int.Parse(txtValeur.Text);
            db.SaveChanges();
            Effacer() ;

        }

      

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtText.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtValeur.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells["IdAnneAcademique"].Value.ToString());
            AnneeAcademique anneeAcademique = db.anneeAcademiques.Find(id);
            db.anneeAcademiques.Remove(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }
    }
}
