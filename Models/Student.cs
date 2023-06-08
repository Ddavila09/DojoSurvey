using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;
public class Student
{
    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters long")]
    public string Name { get; set; }

    [Required(ErrorMessage = "is required")]
    public string Location { get; set; }

    [Required(ErrorMessage = "is required")]
    public string Language { get; set; }

    [Range(20,500)]
    public string Comment { get; set; }

}