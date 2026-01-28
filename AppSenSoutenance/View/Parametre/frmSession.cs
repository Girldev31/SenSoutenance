using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FillerList filler= new FillerList();

        private void frmSession_Load(object sender, EventArgs e)
        {
            
            Effacer();
            dgSession.Columns["IdSession"].Visible = false;
        }
      
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.LibelleSession = txtSession.Text;
            session.IdAnneAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            session.AnneeAcademique = db.anneeAcademiques.Find(session.IdAnneAcademique);
            db.sessions.Add(session);
            db.SaveChanges();
            Effacer();

        }

        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedValue = null;
            dgSession.DataSource = db.sessions.ToList();
            cbbAnneeAcademique.DataSource = filler.fillAnneAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session =db.sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneAcademique;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            session.LibelleSession = txtSession.Text;
            session.IdAnneAcademique = (int?)cbbAnneeAcademique.SelectedValue;
            db.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            db.sessions.Remove(session);
            db.SaveChanges();
            Effacer() ;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            var liste = db.sessions.ToList();

            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            }
            if(txtRanneAcademique.Text !="")
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneAcademique.Contains(txtRanneAcademique.Text)).ToList();
            }



            dgSession.DataSource = liste;

        }
    }
}
