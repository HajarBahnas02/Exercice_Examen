using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Examen
{
    class Exam
    {
        private int idExam { get; set; }
        private Durrée durr { get;set; }
        private string matiere { get; set; }
        private List<Question> qst { get; }
        private List<Etudiant> std { get; }
        public Exam(int id, String matiere, Durrée durr, List<Question> qst, List<Etudiant> student)
        {
            this.idExam = id;
            this.matiere = matiere;
            this.durr = durr;
            this.qst = qst;
            this.qst = qst;
            this.std = student;
        }
    }
}
