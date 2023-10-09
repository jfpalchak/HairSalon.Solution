
namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // Foreign Key
    public int StylistId { get; set; }
    // Reference Navigation Property
    public Stylist Stylist {get; set; }
  }
}