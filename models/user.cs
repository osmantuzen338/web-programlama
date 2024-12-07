using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    [MaxLength(255)]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}