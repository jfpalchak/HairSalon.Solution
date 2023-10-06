using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }

    // Collection Navigation Property
    public List<Client> Clients { get; set; }
  }
}