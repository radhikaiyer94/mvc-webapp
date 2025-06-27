using System.ComponentModel.DataAnnotations;

namespace MyMVCProject.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    public required string Title { get; set; }

    public string? Genre { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }
}