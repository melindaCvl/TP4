using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplorateurDossiers
{
    public class Fichier : IArborescence
    {
        String Chemin;
        String Nom;

        public Fichier(String chemin, String nom)
        {
            this.Chemin = chemin;
            this.Nom = nom;
        }

        public void Contenu()
        {
            Console.WriteLine("Je suis un fichier");
        }

        public IArborescence GetElement(string nom)
        {
            Console.WriteLine("Je suis un fichier, je n'ai pas d'arborescence !");
            return this;
        }

        public string GetNom()
        {
            if (Nom == null)
            {
                return Chemin;
            }
            else
            {
                return Nom;
            }
        }
    }
}