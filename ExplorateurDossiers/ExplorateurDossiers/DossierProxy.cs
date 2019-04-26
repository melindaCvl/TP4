using System;
using System.IO;

namespace ExplorateurDossiers
{
    public class DossierProxy : Dossier
    {
        public DossierReel unDossier;

        public DossierProxy(string chemin, string nom) : base(chemin, nom)
        {
            unDossier = new DossierReel(chemin, nom);
        }

        public override void Contenu()
        {
            unDossier.Contenu();
        }

        public override IArborescence GetElement(string nom)
        {
            return unDossier.GetElement(nom);
        }
    }
}