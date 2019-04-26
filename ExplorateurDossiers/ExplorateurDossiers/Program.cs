using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurDossiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // On part de la racine
            DossierProxy dos = new DossierProxy("C:\\", null);
            dos.Contenu();
            Console.WriteLine();

            // On parcourt le dossier Windows
            IArborescence elem = dos.GetElement("Windows");
            elem.Contenu();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
