using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
[Table("Orders")]
public class Order
{
    [Key]
    public int OrderID { get; set; }

    [Required]
    [StringLength(5)]
    public string CustomerID { get; set; }

    public int? EmployeeID { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    [StringLength(40)]
    public string ShipVia { get; set; }

    public decimal? Freight { get; set; }

    [StringLength(40)]
    public string ShipName { get; set; }

    [StringLength(60)]
    public string ShipAddress { get; set; }

    [StringLength(15)]
    public string ShipCity { get; set; }

    [StringLength(15)]
    public string ShipRegion { get; set; }

    [StringLength(10)]
    public string ShipPostalCode { get; set; }

    [StringLength(15)]
    public string ShipCountry { get; set; }

    [ForeignKey("CustomerID")]
    public virtual Customer Customer { get; set; }
}