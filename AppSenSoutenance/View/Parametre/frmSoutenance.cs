using AppSenSoutenance.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Parametre
{
    public partial class frmSoutenance : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        public frmSoutenance()
        {
            InitializeComponent();

            dgSoutenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSoutenance.MultiSelect = false;
            dgSoutenance.ClearSelection(); 

            ChargerSoutenances();

        }
        // ===================== CHARGEMENT =====================
        private void ChargerSoutenances()
        {
            dgSoutenance.DataSource = null;
            dgSoutenance.DataSource = db.soutenances.ToList();
            dgSoutenance.Columns[0].Visible = false;
        }
        // ===================== VERIFICATION CHAMPS =====================
        private bool ChampsValides()
        {
            if (txtLieu.Text == "" ||
                txtResultat.Text == "" ||
                txtMention.Text == "" ||
                txtObservation.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return false;
            }
            return true;
        }



        // ===================== LOAD =====================
        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            dgSoutenance.DataSource = db.soutenances.ToList();
            dgSoutenance.Columns[0].Visible = false;
        }

        public void Effacer()
        {
            txtLieu.Clear();
            txtResultat.Clear();
            txtMention.Clear();
            txtObservation.Clear();
            dtpDate.Value = DateTime.Now;

            dgSoutenance.DataSource = db.soutenances.ToList();
            txtLieu.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ChampsValides())
                return;

            Soutenance s = new Soutenance()
            {
                LieuSoutenance = txtLieu.Text,
                DateSoutenance = dtpDate.Value,
                ResultatSoutenance = txtResultat.Text,
                MentionSoutenance = txtMention.Text,
                observationSoutenance = txtObservation.Text
            };
            db.soutenances.Add(s);
            db.SaveChanges();

            MessageBox.Show("Soutenance ajoutée");
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow != null)
            {
                txtLieu.Text = dgSoutenance.CurrentRow.Cells[1].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(dgSoutenance.CurrentRow.Cells[2].Value);
                txtResultat.Text = dgSoutenance.CurrentRow.Cells[3].Value.ToString();
                txtMention.Text = dgSoutenance.CurrentRow.Cells[4].Value.ToString();
                txtObservation.Text = dgSoutenance.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une soutenance avant de modifier");
                return;
            }

            if (!ChampsValides())
                return;

            int id = int.Parse(dgSoutenance.SelectedRows[0].Cells[0].Value.ToString());
            Soutenance s = db.soutenances.Find(id);

            s.LieuSoutenance = txtLieu.Text;
            s.DateSoutenance = dtpDate.Value;
            s.ResultatSoutenance = txtResultat.Text;
            s.MentionSoutenance = txtMention.Text;
            s.observationSoutenance = txtObservation.Text;

            db.SaveChanges();

            MessageBox.Show("Soutenance modifiée");
            Effacer();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une soutenance avant de supprimer");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Voulez-vous vraiment supprimer cette soutenance ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (r == DialogResult.Yes)
            {
                int id = int.Parse(dgSoutenance.SelectedRows[0].Cells[0].Value.ToString());
                Soutenance s = db.soutenances.Find(id);

                db.soutenances.Remove(s);
                db.SaveChanges();

                MessageBox.Show("Soutenance supprimée");
                Effacer();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valeur = txtRecherche.Text;

            dgSoutenance.DataSource = db.soutenances
                .Where(s => s.LieuSoutenance.Contains(valeur)
                         || s.MentionSoutenance.Contains(valeur)
                         || s.ResultatSoutenance.Contains(valeur))
                .ToList();
        }
    }
}
    
