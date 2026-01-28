using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    public class AnneeAcademique
    {
        [Key]
        public int IdAnneAcademique {  get; set; }
        [Required , MaxLength(10)]
        public string LibelleAnneAcademique {  get; set; }
        [Required]
        public int AnneAcademiqueVal { get; set; }

    }
}
