using System;
using System.IO;

namespace ExplorateurDossiers
{
    public class DossierReel : Dossier
    {
        public DossierReel(string chemin, string nom) : base(chemin, nom)
        {
        }

        public override void Contenu()
        {
            String CheminEntier = Chemin + "\\" + Nom;
            
            DirectoryInfo dir = new DirectoryInfo(@CheminEntier);

            try
            {
                foreach (var fi in dir.EnumerateFiles())
                {
                    String nomFichier = fi.Name;
                    Fichier fich = new Fichier(CheminEntier, nomFichier);
                    listeElements.Add(fich);

                    Console.WriteLine(nomFichier);
                }

                foreach (var di in dir.EnumerateDirectories("*"))
                {
                    String nomDoss = di.Name;
                    DossierProxy doss = new DossierProxy(CheminEntier, nomDoss);
                    listeElements.Add(doss);

                    Console.WriteLine(nomDoss);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"{exc.Message}");
            }
        }

        public override IArborescence GetElement(string nom)
        {

            IArborescence monElement = null;
            foreach (IArborescence element in listeElements) {
                String nomElement = element.GetNom();
                if (string.Compare(nomElement, nom) == 0) {
                    monElement = element;
                }
            }

            return monElement;
        }
    }
}