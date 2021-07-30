using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int Id { get; set; }

    [Required()]
    [DisplayName("Stylist Name")]
    public string Name { get; set; }

    [Required()]
    [DisplayName("Info On Stylist")]
    public string Description { get; set; }

    public virtual ICollection<Client> Clients { get; set; }

    public Stylist ()
    {
      Clients = new HashSet<Client>(); 
    }
  }
}