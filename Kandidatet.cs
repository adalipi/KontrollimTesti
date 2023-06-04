using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrollimTesti
{
    public class Kandidatet
    {
        string[] testi1 = File.ReadAllLines("samples/testi1.txt");
        string[] testi2 = File.ReadAllLines("samples/testi2.txt");
        string[] testi3 = File.ReadAllLines("samples/testi3.txt");

        IDictionary<string, int> lista1 = new Dictionary<string, int>();
        IDictionary<string, int> lista2 = new Dictionary<string, int>();
        

        public IList<string> GjeneroListen(string? path = null)
        { 
            IList<string> listaRezultat = new List<string>();
            IList<string> listaKandidat = new List<string>();

            foreach (var item in testi1)
            {
                var rreshti = item.Split(',');
                var email = rreshti[0].Trim().ToLower();
                var piket = int.Parse(rreshti[1]);

                lista1.Add(email, piket);
            }

            foreach (var item in testi2)
            {
                var rreshti = item.Split(',');
                var email = rreshti[0].Trim().ToLower();
                var piket = int.Parse(rreshti[1]);

                lista2.Add(email, piket);
            }

            foreach (var item in testi3)
            {
                var rreshti = item.Split(',');
                var email = rreshti[0].Trim().ToLower();

                if (lista1.ContainsKey(email) && lista2.ContainsKey(email))
                {
                    var piket = int.Parse(rreshti[1]);

                    piket += lista1[email] + lista2[email];

                    listaRezultat.Add($"{email} = {piket}");
                    listaKandidat.Add(email);
                }
            }

            if(path is not null) 
                File.WriteAllLines(path, listaRezultat);

            return listaKandidat;
        }
    }
}
