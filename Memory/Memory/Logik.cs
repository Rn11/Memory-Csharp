using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Memory
{
    class Logik
    {
        public static List<Image> mischen()
        {
            // Random integer wird benoetigt
            Random rn = new Random();
            // List<Image> vom Typ File welches die eingelesenen Pfade der Bilder
            // beinhaltet
            List<Image> eingelesen = new List<Image>();
            // List<Image> vom Typ File welches die gemischten Pfade der Bilder
            // beinhaltet
            List<Image> gemischt = new List<Image>();
            int position = 0;

            // Bilder werden eingelesen
            try
            {
                eingelesen.Add(Properties.Resources._1);
                eingelesen.Add(Properties.Resources._2);
                eingelesen.Add(Properties.Resources._3);
                eingelesen.Add(Properties.Resources._4);
                eingelesen.Add(Properties.Resources._5);
                eingelesen.Add(Properties.Resources._6);
                eingelesen.Add(Properties.Resources._7);
                eingelesen.Add(Properties.Resources._8);
                eingelesen.Add(Properties.Resources._9);
                eingelesen.Add(Properties.Resources._10);
                eingelesen.Add(Properties.Resources._11);
                eingelesen.Add(Properties.Resources._12);

                // Bilder werden aus der List<Image> 'eingelesen' hinten an 'eingelesen'
                // angefuegt
                position = eingelesen.Count;
                for (int i = 0; i < position; i++)
                {
                    eingelesen.Add(eingelesen[i]);
                }

                // Mische Eintraege solange "eingelesen" noch Elemente hat
                while (0 < eingelesen.Count)
                {
                    // Generiere eine Zufallszahl zwischen 0 und der Groesse der
                    // "eingelesen" List<Image>
                    int random = rn.Next(eingelesen.Count);
                    // Ein Eintrag aus "eingelesen" wird nun mit der Zufallszahl
                    // ausgelesen und zu gemischt hinzugefuegt
                    gemischt.Add(eingelesen[random]);
                    // Anschliessend wird dieser Eintrag aus "eingelesen" entfernt
                    eingelesen.RemoveAt(random);
                    // "eingelesen" wird gekuerzt
                    eingelesen.TrimExcess();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Es konnte nicht auf die Bilder zugegriffen werden. Fehler: " + ex.Message);
            }

            return gemischt;
        }
    }
}
