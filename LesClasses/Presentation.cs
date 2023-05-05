using lesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesClasses {
        public class Presentation {
            // attribut
            private List<Presentation> lesPresentations { get; }

            // Propriétés automatiques
            public int Id { get; set; }
            public DateTime Date { get; set; }

            public string Sujet { get; set; }


            // Constructeur
            public Presentation(int id, DateTime date, string sujet)
                => (Id, Date, Sujet, lesPresentations) = (id, date, sujet,  new List<Presentation>());

            // méthode
            public void ajouterPresentation(Presentation unePresentation) {
                lesPresentations.Add(unePresentation);
            }
            
        }
}
