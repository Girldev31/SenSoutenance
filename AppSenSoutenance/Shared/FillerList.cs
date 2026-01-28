using AppSenSoutenance.Models;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Net.Mime.MediaTypeNames;

namespace AppSenSoutenance.Shared
{
   public class FillerList
{
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        public List<ListItem> fillAnneAcademique()
        {
           List<ListItem> laliste = new List<ListItem>();
            var liste = db.anneeAcademiques.ToList();
             laliste.Add(new ListItem
              {
                    Value = null,
                    Text = "Selectionner"
              });
                foreach (var t in liste)
                {
                    var item = new ListItem
                    {
                        Value = t.IdAnneAcademique.ToString(),
                        Text = t.LibelleAnneAcademique.ToString()
                    };
                    laliste.Add(item);

                }
                return laliste;

        }
        public List<ListItem> fillDepartement()
        {
            List<ListItem> laliste = new List<ListItem>();
            var liste = db.departements.ToList();
            laliste.Add(new ListItem
            {
                Value = null,
                Text = "Selectionner"
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdDepartement.ToString(),
                    Text = t.LibelleDepartement.ToString()
                };
                laliste.Add(item);
            }
            return laliste;
        }

    }
}
