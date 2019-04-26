using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplorateurDossiers
{
    public interface IArborescence
    {
        void Contenu();
        IArborescence GetElement(String nom);
        String GetNom();
    }
}