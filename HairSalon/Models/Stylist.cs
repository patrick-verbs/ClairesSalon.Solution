using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }
        
        public int StylistId { get; set; }
        public string NameFirst { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public virtual ICollection<Client> Clients { get; set; }
    }
}