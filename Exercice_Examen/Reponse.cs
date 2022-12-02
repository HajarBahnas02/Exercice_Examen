using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Examen
{
    internal class Reponse
    {
        private Question qst;
            private List<string> reponse
        {
            get { return reponse; }
        }
    

        void ajouterreponse(Object ans)
        {
            if (qst is Qcm)
            {
                reponse.Add(ans);
            }
            else
            {
                reponse.Insert(0, ans);
            }
        }

    }
}
