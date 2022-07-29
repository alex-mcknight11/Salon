using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Clients
  {
    public Clients()
    {
      this.Stylist = new HashSet<Stylist>();
    }

    public int ClientsId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Stylist> Stylist { get; set; }
  }
}