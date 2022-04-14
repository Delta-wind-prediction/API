using System.ComponentModel.DataAnnotations;

namespace Common.models;

public class WeatherReport
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public int KnmiId { get; set; }
    [Required]
    public DateTime DateTime { get; set; }
    [Required]
    public int AirPressure { get; set; } 
    [Required]
    public int RainFall { get; set; } 
    [Required]
    public float WindSpeed { get; set; } 
    [Required]
    public float Temperature { get; set; } 
    [Required]
    public float WindGuest { get; set; } 
    [Required]
    public int WindDirection { get; set; } 
    [Required]
    public int RelativeHumidity { get; set; }
}