using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDlaOli
{
    public class ZarzadaniePlikiem
    {
        List<string> lista = new List<string>();
        public string NazwaPliku1 { get; set; }
        public string NazwaPliku2 { get; set; }
        public string NazwaPliku3 { get; set; }

        public string[] plik1;
        public string[] plik2;
        public string[] plik3;

        public bool ZaczytajDane()
        {
            if (!File.Exists(NazwaPliku1))
            {
                return false;
            }
            plik1 = File.ReadAllLines(NazwaPliku1);
            
            if (!File.Exists(NazwaPliku2))
            {
                return false;
            }
            plik2 = File.ReadAllLines(NazwaPliku2);

            return true;

        }

        public void Znajdz()
        {
            WysczyscListe();
            int pozycjaTab=0;
            foreach(var liniePliku1 in plik1)
            {
                pozycjaTab=liniePliku1.IndexOf("\t");
                if (pozycjaTab >= 0)
                {
                    string NumerSeryjnyCzesci = liniePliku1.Substring(0, pozycjaTab);
                    foreach(var liniePliku2 in plik2)
                    {
                        if (NumerSeryjnyCzesci.Equals(liniePliku2))
                        {
                            
                            lista.Add(liniePliku1.Replace('\t',' '));
                            
                        }
                    }
                }
            }

            File.WriteAllLines(NazwaPliku3, lista);
        }

        public void WysczyscListe()
        {
            lista.Clear();
        }
    }
}
