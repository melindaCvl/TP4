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
            // On navigue de dossier en dossier (valeurs à changer en local)
            DossierProxy dos = new DossierProxy("C:\\Users\\cherr_000\\Desktop\\EPSI", "MSPR");
            dos.Contenu();
            Console.WriteLine();

            // On parcourt le dossier BDD du répertoire MSPR
            IArborescence elem = dos.GetElement("BDD");
            elem.Contenu();
            Console.WriteLine();

            // On parcourt le dossier Rendu du répertoire BDD
            IArborescence elem2 = elem.GetElement("Rendu");
            elem2.Contenu();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
