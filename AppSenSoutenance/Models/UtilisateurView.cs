using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    public class UtilisateurView
    {
        public int IdUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
        public string TelephoneUtilisateur { get; set; }
        public string EmailUtilisateur { get; set; }
        public string TypeUtilisateur { get; set; }

        public string Matricule { get; set; }
        public string Specialite { get; set; }
        public virtual Departement Departement { get; set; }
    }
}
