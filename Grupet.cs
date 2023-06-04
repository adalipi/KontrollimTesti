using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrollimTesti
{
    public class Grupet
    {
        public IList<string> Grupo(IList<string> lista, string path = null)
        {
            var grupet = new List<string>();

            int grupi = 1;
            while (lista.Count > 4) 
            { 
                int x1 = Random.Shared.Next(lista.Count);
                var emaili1 = lista[x1];
                lista.Remove(emaili1);

                int x2 = Random.Shared.Next(lista.Count);
                var emaili2 = lista[x2];
                lista.Remove(emaili2);
                
                int x3 = Random.Shared.Next(lista.Count);
                var emaili3 = lista[x3];
                lista.Remove(emaili3);

                int x4 = Random.Shared.Next(lista.Count);
                var emaili4 = lista[x4];
                lista.Remove(emaili4);

                grupet.Add($"Grupi{grupi}: {emaili1}, {emaili2}, {emaili3}, {emaili4}");
                grupi++;
            }

            var grupiFundit = "";
            foreach (var item in lista) 
            { 
                grupiFundit += item + ", ";
            }

            grupet.Add($"Grupi{grupi}: {grupiFundit}");

            if (path != null)
                File.WriteAllLines(path, grupet);

            return grupet;
        }
    }
}
