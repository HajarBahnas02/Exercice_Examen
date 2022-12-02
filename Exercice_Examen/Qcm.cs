using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Examen
{
    class Qcm : Question
    {
        private int nbrePrepositions
        {
            get;
            set;
        }
        public bool Iscorrecte(Reponse res)
        {
            if (res.isTrue == 1)
            {
                return (true);
            }

        }
    }
}
