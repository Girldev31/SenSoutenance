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
    public partial class frmDepartement : Form
    {
        public frmDepartement()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext sen = new BdSenSoutenanceContext();
        private void frmDepartement_Load(object sender, EventArgs e)
        {
            dgDepartement.DataSource = sen.departements.ToList();
            dgDepartement.Columns["IdDepartement"].Visible = false;
        }
        private void Effacer()
        {
            txtLibelle.Clear();
            dgDepartement.DataSource = sen.departements.ToList();
            txtLibelle.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Departement departement = new Departement()
            {
                LibelleDepartement = txtLibelle.Text
            };
            sen.departements.Add(departement);
            sen.SaveChanges();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int ? id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement departement = sen.departements.Find(id);
            departement.LibelleDepartement = txtLibelle.Text;
            sen.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int ? id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement departement = sen.departements.Find(id);
            sen.departements.Remove(departement);
            sen.SaveChanges();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtLibelle.Text = dgDepartement.CurrentRow.Cells["LibelleDepartement"].Value.ToString();
        }
    }
}
