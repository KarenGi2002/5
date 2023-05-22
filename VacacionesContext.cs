using Microsoft.EntityFrameworkCore;
using vacaciones.Models;
namespace vacaciones;


public class vacacionesContext: DbContext{
public DbSet<Empleado>? Empleado{get;set;}
public DbSet<Cargo>? Cargo{get;set;}
public DbSet<Vacacion1>? vacacion1{get;set;}
public DbSet<CodigoTrabajo>? CodigoTrabajo{get;set;}
public vacacionesContext(DbContextOptions<vacacionesContext> options) : base(options){  }
}