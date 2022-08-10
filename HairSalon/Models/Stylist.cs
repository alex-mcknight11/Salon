using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
  public Stylist()
  {
    this.Clients = new HashSet<Clients>();
  }
    public int StylistId { get; set; }
    public string Description { get; set; }
    public int ClientsId { get; set; }
    public virtual ICollection<Clients> Clients { get; set; }
  }
}