using System;
namespace Entities
{
    public class Abonnement
    {
        public int IdAbonnement{ get; set; }
        public Ressource Ressource { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public DateOnly DateDebut { get; set; }
        public DateOnly Datefin { get; set; }
        public int Durée { get; set; }
        public int PériodeEssai { get; set; }


    }

}

