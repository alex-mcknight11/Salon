using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    this.Clients = new HashSet<Client>();
  }
    public int StylistId { get; set; }
    public string Description { get; set; }
    public int ClientsId { get; set; }
    public virtual Clients Clients { get; set; }
  }