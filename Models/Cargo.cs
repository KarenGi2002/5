
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vacaciones.Models;

public class Cargo{
[Key]
    public Guid cargoId{get;set;}

[NotMapped]
[ForeignKey("Empleado")]
    public  string? nombre{get;set;}
    public virtual Empleado? Empleado{get;set;}
}