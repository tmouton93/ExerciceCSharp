using System;
using System.Collections.Generic;
using System.Text;

namespace ReleveMeteo
{
    class RelevéMensuel
    {

        public DateTime Mois { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Precip { get; set; }
        public double Ensol { get; set; }

        public RelevéMensuel(string ligne)
        {
            

           char sep = '\t';

            string[] colonne = ligne.Split(sep);

            Mois=DateTime.Parse(colonne[0]);
            TempMin = double.Parse(colonne[1]);
            TempMax = double.Parse(colonne[2]);
            Precip = double.Parse(colonne[3]);
            Ensol = double.Parse(colonne[4]);

        }

        public override string ToString()
        {
            return $"{Mois}, {TempMin},{TempMax},{Precip},{Ensol}";
        }







    }
}
