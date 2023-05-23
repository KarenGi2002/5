using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vacaciones.Models;
public class Vacacion1{

[Key]
public Guid VacacionesId{get;set;}

public String? fecha{get;set;}

}

