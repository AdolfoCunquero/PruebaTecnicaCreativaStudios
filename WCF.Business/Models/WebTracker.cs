using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Summary description for WebTracker
/// </summary>
[Table("WebTracker")]
public class WebTracker
{
    [Key]
    public int Id { get; set; }
    [StringLength(250)]
    public string URLRequest { get; set; }
    [StringLength(50)]
    public string SourceIp { get; set; }
    public DateTime TimeOfAction { get; set; }
}