using System.Net;
using System.ComponentModel.DataAnnotations;
namespace vacaciones.Models;
public class CodigoTrabajo{

[Key]
public Guid CodigoTId{get;set;}

[Required]
[MaxLength(250)]
public int antiguedad{get;set;}

[MaxLength(100)]
public int diasOtorgados{get;set;}

[MaxLength(100)]
public Boolean vigente{get;set;}

}