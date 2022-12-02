using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Examen
{
     class noteFinal
    {

        public void CalculNote(Func<string, int> getQuestion)
        {
            int totaleNote=0;
            foreach (Reponse res in reponse)
            {
                if (res.qusetion is QstOuverte)
                {
                    totalNote += getQuestion(res.question.statement);
                }
                else
                {
                    totalNote += res.question.initialScore;


                }
            }
}
