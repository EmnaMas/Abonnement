using System;
namespace Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateOnly DateInscription { get; set; }
        public Role Role { get; set; }

    
       
    }
}

