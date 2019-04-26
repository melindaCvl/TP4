using System;
using System.Collections;

namespace ExplorateurDossiers
{
    public abstract class Dossier : IArborescence
    {

        public ArrayList listeElements = new ArrayList();

        public String Nom;

        public String Chemin;

        public Dossier(String chemin, String nom) {
            this.Chemin = chemin;
            if (nom != null)
            {
                this.Nom = nom;
            }
        }

        abstract public void Contenu();

        abstract public IArborescence GetElement(String nom);

        public String GetNom()
        {
            if (this.Nom == null)
            {
                return Chemin;
            }
            else
            {
            return this.Nom;
            }
        }

    }
}