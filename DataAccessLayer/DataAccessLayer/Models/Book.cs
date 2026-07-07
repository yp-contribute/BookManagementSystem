using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DataAccessLayer.Models;

public partial class Book
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Book Name is required")]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
    [MaxLength(16, ErrorMessage = "Name must be at most 16 characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage ="Author name should be mention")]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
    [MaxLength(16, ErrorMessage = "Name must be at most 16 characters")]
    public string? Author { get; set; }

    public string? Genre { get; set; }

    [Required(ErrorMessage ="Publisher name shoul be mention")]
    public string? Publisher { get; set; }

    [Required(ErrorMessage ="Should be enter in DD-MM-YYYY format")]
    [StringLength(10)]
    public DateOnly? PublishDate { get; set; }
}
