using AppSenSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Account
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FillerList filler = new FillerList();

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            chargerListeUtilisateurs();
        }

        private void chargerListeUtilisateurs()
        {
            List<UtilisateurView> liste = new List<UtilisateurView>();

            // ================== CANDIDATS ==================
            var candidats = db.candidats.ToList();
            foreach (Candidat c in candidats)
            {
                liste.Add(new UtilisateurView
                {
                    IdUtilisateur = c.IdUtilisateur,
                    NomUtilisateur = c.NomUtilisateur,
                    PrenomUtilisateur = c.PrenomUtilisateur,
                    TelephoneUtilisateur = c.TelephoneUtilisateur,
                    EmailUtilisateur = c.EmailUtilisateur,
                    TypeUtilisateur = "Candidat",
                    Matricule = c.MatricaleCandidat,
                    Specialite = null,
                    Departement = null
                });
            }

            // ================== PROFESSEURS ==================
            var professeurs = db.professeurs.ToList();
            foreach (Professeur p in professeurs)
            {
                liste.Add(new UtilisateurView
                {
                    IdUtilisateur = p.IdUtilisateur,
                    NomUtilisateur = p.NomUtilisateur,
                    PrenomUtilisateur = p.PrenomUtilisateur,
                    TelephoneUtilisateur = p.TelephoneUtilisateur,
                    EmailUtilisateur = p.EmailUtilisateur,
                    TypeUtilisateur = "Professeur",
                    Matricule = null,
                    Departement = null,
                    Specialite = p.SpeciliteProfeur
                });
            }

            // ================== Chef Departement ==================
            var chefdepartement = db.chefDepartements.ToList();
            foreach (ChefDepartement ch in chefdepartement) {
                liste.Add(new UtilisateurView
                {
                    IdUtilisateur = ch.IdUtilisateur,
                    NomUtilisateur = ch.NomUtilisateur,
                    PrenomUtilisateur = ch.PrenomUtilisateur,
                    TelephoneUtilisateur = ch.TelephoneUtilisateur,
                    EmailUtilisateur = ch.EmailUtilisateur,
                    TypeUtilisateur = "Chef Departement",
                    Matricule = null,
                    Departement = ch.Departement,
                    Specialite = null


                });

            }
            dgUtilisateur.DataSource = liste;

            // Masquer l'ID
            dgUtilisateur.Columns["IdUtilisateur"].Visible = false;
        }
        private void EffacerChamps()
        {
            // Effacer les champs pour Candidat
            txtNomCand.Clear();
            txtPrenomCand.Clear();
            txtPhoneCand.Clear();
            txtEmailCand.Clear();
            txtMatriculeCand.Clear();
            txtNomCand.Focus();
            // Effacer les champs pour Professeur
            txtNomProf.Clear();
            txtPrenomProf.Clear();
            txtPhoneProf.Clear();
            txtEmailProf.Clear();
            txtSpecialiteProf.Clear();
            txtNomCand.Focus();
            //Effacer les champs pour Chef Departement
            txtNomCd.Clear();
            txtPhoneCd.Clear();
            txtEmailCd.Clear();
            txtPrenomCd.Clear();
            txtPhoneCd.Clear();
            cbbDepartement.DataSource = filler.fillDepartement();
            cbbDepartement.DisplayMember = "Text";
            cbbDepartement.ValueMember = "Value";
            txtNomCd.Focus();

        }

        private void btnSender_Click(object sender, EventArgs e)
        {
            Candidat c = new Candidat();
            c.NomUtilisateur = txtNomCand.Text;
            c.PrenomUtilisateur = txtPrenomCand.Text;
            c.TelephoneUtilisateur = txtPhoneCand.Text;
            c.EmailUtilisateur = txtEmailCand.Text;
            c.MatricaleCandidat = txtMatriculeCand.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                c.MotPasse = Shared.Crypted.GetMd5Hash(md5Hash, "Pass123");
            }
            db.candidats.Add(c);
            db.SaveChanges();
            chargerListeUtilisateurs();
            EffacerChamps();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = (int)dgUtilisateur.CurrentRow.Cells["IdUtilisateur"].Value;

            var c = db.candidats.Find(id);
            if (c == null) return;

            c.NomUtilisateur = txtNomCand.Text;
            c.PrenomUtilisateur = txtPrenomCand.Text;
            c.TelephoneUtilisateur = txtPhoneCand.Text;
            c.EmailUtilisateur = txtEmailCand.Text;
            c.MatricaleCandidat = txtMatriculeCand.Text;

            db.SaveChanges();
            chargerListeUtilisateurs();
            EffacerChamps();
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            int id = (int)dgUtilisateur.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = db.candidats.Find(id);

            if (c != null)
            {
                db.candidats.Remove(c);
                db.SaveChanges();
                chargerListeUtilisateurs();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNomCand.Text = dgUtilisateur.CurrentRow.Cells["NomUtilisateur"].Value?.ToString();
            txtPrenomCand.Text = dgUtilisateur.CurrentRow.Cells["PrenomUtilisateur"].Value?.ToString();
            txtPhoneCand.Text = dgUtilisateur.CurrentRow.Cells["TelephoneUtilisateur"].Value?.ToString();
            txtEmailCand.Text = dgUtilisateur.CurrentRow.Cells["EmailUtilisateur"].Value?.ToString();
            txtMatriculeCand.Text = dgUtilisateur.CurrentRow.Cells["Matricule"].Value?.ToString();
        }

        private void btnSenderProf_Click(object sender, EventArgs e)
        {
            Professeur p = new Professeur();
            p.NomUtilisateur = txtNomProf.Text;
            p.PrenomUtilisateur = txtPrenomProf.Text;
            p.TelephoneUtilisateur = txtPhoneProf.Text;
            p.EmailUtilisateur = txtEmailProf.Text;
            p.SpeciliteProfeur = txtSpecialiteProf.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                p.MotPasse = Shared.Crypted.GetMd5Hash(md5Hash, "Pass123");
            }
            db.professeurs.Add(p);
            db.SaveChanges();
            chargerListeUtilisateurs();
            EffacerChamps();
        }

        private void btnEditProf_Click(object sender, EventArgs e)
        {
            int id = (int)dgUtilisateur.CurrentRow.Cells["IdUtilisateur"].Value;
            var p = db.professeurs.Find(id);
            if (p == null) return;
            p.NomUtilisateur = txtNomProf.Text;
            p.PrenomUtilisateur = txtPrenomProf.Text;
            p.TelephoneUtilisateur = txtPhoneProf.Text;
            p.EmailUtilisateur = txtEmailProf.Text;
            p.SpeciliteProfeur = txtSpecialiteProf.Text;
            db.SaveChanges();
            chargerListeUtilisateurs();
            EffacerChamps();

        }

        private void btnDelectProf_Click(object sender, EventArgs e)
        {
            int id = (int)dgUtilisateur.CurrentRow.Cells["IdUtilisateur"].Value;
            var p = db.professeurs.Find(id);
            if (p == null)
            {
                db.professeurs.Remove(p);
                db.SaveChanges();
                chargerListeUtilisateurs();
            }

        }

        private void btnSelectProf_Click(object sender, EventArgs e)
        {
            txtNomProf.Text = dgUtilisateur.CurrentRow.Cells["NomUtilisateur"].Value?.ToString();
            txtPrenomProf.Text = dgUtilisateur.CurrentRow.Cells["PrenomUtilisateur"].Value?.ToString();
            txtPhoneProf.Text = dgUtilisateur.CurrentRow.Cells["TelephoneUtilisateur"].Value?.ToString();
            txtEmailProf.Text = dgUtilisateur.CurrentRow.Cells["EmailUtilisateur"].Value?.ToString();
            txtSpecialiteProf.Text = dgUtilisateur.CurrentRow.Cells["Specialite"].Value?.ToString();
        }

        private void btnSenderCd_Click(object sender, EventArgs e)
        {
            ChefDepartement ch = new ChefDepartement();
            ch.NomUtilisateur = txtNomCd.Text;
            ch.PrenomUtilisateur = txtPrenomCd.Text;
            ch.TelephoneUtilisateur = txtPhoneCd.Text;
            ch.EmailUtilisateur = txtEmailCd.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                ch.MotPasse = Shared.Crypted.GetMd5Hash(md5Hash, "Pass123");
            }
            ch.Departement = db.departements.Find(ch.IdDepartement);
            db.chefDepartements.Add(ch);
            db.SaveChanges();
            chargerListeUtilisateurs();
            EffacerChamps();
        }

        private void btnEditCd_Click(object sender, EventArgs e)
        {
            int id = (int)dgUtilisateur.CurrentRow.Cells["IdUtilisateur"].Value;
            var ch = db.chefDepartements.Find(id);
            if (ch == null) return;
            ch.NomUtilisateur = txtNomCd.Text;
            ch.PrenomUtilisateur = txtPrenomCd.Text;
            ch.TelephoneUtilisateur = txtPhoneCd.Text;
            ch.EmailUtilisateur = txtEmailCd.Text;
            ch.IdDepartement = (int)cbbDepartement.SelectedValue;
            db.SaveChanges();
            chargerListeUtilisateurs();
            EffacerChamps();
        }

        private void btnDelectCd_Click(object sender, EventArgs e)
        {
            int id = (int)dgUtilisateur.CurrentRow.Cells["IdUtilisateur"].Value;
            var ch = db.chefDepartements.Find(id);
            if (ch == null)
            {
                db.chefDepartements.Remove(ch);
                db.SaveChanges();
                chargerListeUtilisateurs();
            }
        }

        private void btnSelectCd_Click(object sender, EventArgs e)
        {
            txtNomCd.Text = dgUtilisateur.CurrentRow.Cells["NomUtilisateur"].Value?.ToString();
            txtPrenomCd.Text = dgUtilisateur.CurrentRow.Cells["PrenomUtilisateur"].Value?.ToString();
            txtPhoneCd.Text = dgUtilisateur.CurrentRow.Cells["TelephoneUtilisateur"].Value?.ToString();
            txtEmailCd.Text = dgUtilisateur.CurrentRow.Cells["EmailUtilisateur"].Value?.ToString();
            cbbDepartement.SelectedValue = dgUtilisateur.CurrentRow.Cells["Departement"].Value?.ToString();
        }
    }
}
