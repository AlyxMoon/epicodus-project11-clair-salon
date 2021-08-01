using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
  [Table("client")]
  public class Client
  {
    public int Id { get; set; }

    [Required()]
    [DisplayName("Stylist")]
    [ForeignKey("Stylist")]
    public int Id_Stylist { get; set; }

    [Required()]
    [DisplayName("Client Name")]
    public string Name { get; set; }

    public virtual Stylist Stylist { get; set; }
  }
}