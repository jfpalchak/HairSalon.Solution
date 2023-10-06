
namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }

    // Foreign Key
    public int StylistId { get; set; }
    // Reference Navigation Property
    public Stylist Stylist {get; set; }
  }
}