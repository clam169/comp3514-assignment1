using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models {

  public class Student {
      [Key]
    public int StudentId { get; set; }
    [Display(Name="First Name")]
    [MaxLength(40)]
    [Required]
    public string FirstName { get; set; }
    [Display(Name="Last Name")]
    [MaxLength(40)]
        [Required]

    public string LastName { get; set; }
    [Display(Name="Mobile Number")]
    [MaxLength(15)]
        [Required]

    public string MobileNumber { get; set; }
    [Display(Name="Email Address")]
    [MaxLength(200)]
        [Required]

    public string Email { get; set; }
    [Display(Name="City of residence")]
    [MaxLength(25)]
        [Required]

    public string City { get; set; }
    [MaxLength(25)]
        [Required]

    public string Specialization { get; set; }
  }

}