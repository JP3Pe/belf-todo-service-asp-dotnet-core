
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User2")]
public class User2
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
	[Required]
	[MaxLength(50)]
	public string FirstName { get; set; }
	[Required]
	[MaxLength(50)]
	public string LastName { get; set; }
	[Required]
	[MaxLength(250)]
	public string Address { get; set; }
	[Required]
	[MaxLength(50)]
	public string Country { get; set; }
	[MaxLength(15)]
	public int Mobile { get; set; }
}