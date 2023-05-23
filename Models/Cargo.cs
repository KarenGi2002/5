
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vacaciones.Models;

public class Cargo{
 [Key]
 public Guid CargoId{get;set;} =Guid.NewGuid();

public String? nombre{get;set;}
   
}