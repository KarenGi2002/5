using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace vacaciones.Models;
public class Empleado{
[Key]
public Guid EmpleadoId{get;set;}

[Required]
[MaxLength(250)]
public String?  Nombre{get;set;}

[MaxLength(100)]
public String? fechaingreso{get;set;}

[Required]
public Boolean disponible{get;set;}

[ForeignKey("CargoId")]
public Guid CargoId{get;set;} 

public virtual Cargo? Cargo{get;set;}

[ForeignKey("VacacionesId")]
public Guid VacacionesId{get;set;}

public virtual Vacacion1? Vacacion1{get;set;}

    }
 