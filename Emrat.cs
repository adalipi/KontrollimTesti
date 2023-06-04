using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrollimTesti
{
    public class Emrat
    {
        string[] testi1 = File.ReadAllLines("samples/emri.txt");
        public void GjeneroListen(IList<string> lista, string path)
        {
            IList<string> listaRezultat = new List<string>();

            foreach (var item in lista)
            {
                var emri = testi1.FirstOrDefault(x => x.ToLower().Contains(item.ToLower()));

                if (emri != null)
                    listaRezultat.Add($"{emri}");
                else
                    listaRezultat.Add($"PA EMER {item}");
            }

            File.WriteAllLines(path, listaRezultat);
        }
    }
}
