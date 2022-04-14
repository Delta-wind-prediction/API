using System.ComponentModel.DataAnnotations;

namespace Common.models;

public class Windmill
{
    [Key]
    [Required]
    public Guid Id { get; set; } 
    [Required]
    public float EnergyProduced { get; set; } 
    [Required]
    public DateTime DateTime { get; set; } 
}