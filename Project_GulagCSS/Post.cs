using System;
using System.ComponentModel.DataAnnotations;

public class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    [StringLength(50)]
    public string Category { get; set; }

    [Required]
    public DateTime CreateDate { get; set; }

    // Foreign key property
    public int UserId { get; set; }

    // Navigation property
    public User User { get; set; }
}
