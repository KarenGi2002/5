using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vacaciones.Models;
public class Empleado{

[Key]
public Guid EmpleadoId{get;set;} = Guid.NewGuid();

[Required]
[MaxLength(250)]
public string?  nombre{get;set;}

[MaxLength(100)]
public string? fechaingreso{get;set;}

[Required]
public string? disponible{get;set;}

[NotMapped]
[ForeignKey ("Cargo")]
public Guid cargoId{get;set;}  

public virtual Cargo? Cargo{get;set;}


}