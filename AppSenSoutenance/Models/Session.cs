using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    public class Session
    {
        [Key]
        public int IdSession { get; set; }
        [Required, MaxLength(50)]
        public string LibelleSession { get; set; }

        public int? IdAnneAcademique { get; set; }

        [ForeignKey("IdAnneAcademique")]

        public virtual AnneeAcademique AnneeAcademique {get; set; }
    }
}
