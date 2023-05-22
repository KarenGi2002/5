using vacaciones.Models;
 namespace vacaciones.Services;


public class Vacacion1Service: IVacacion1Service{
    //inyeccion de dependencias contex a la bd
    vacacionesContext context;

public Vacacion1Service(vacacionesContext dbContext){
context= dbContext;
}


//CRUD
//CREATE- insertar a la base de datos
//async await cuando hay comunicacion fuera del codigo
public async Task insertar(Vacacion1 input){
    input.VacacionesId= Guid.NewGuid();
    await context.AddAsync(input);
    await context.SaveChangesAsync();
    }

    //READ-- Obtener de la db

public  IEnumerable<Vacacion1>? obtener(){
    return context.vacacion1;
}
//UPDATE
public async Task actualizar (Guid id, Vacacion1 input){
    var vacacion= context.vacacion1?.Find(id);

    if(vacacion!= null){
    vacacion.fecha= input.fecha;

     await context.SaveChangesAsync();
    }
}
//delete
public async Task eliminar (Guid id){
    var vacacion= context.vacacion1?.Find(id);
    if(vacacion != null){
     context.Remove(vacacion);
     await context.SaveChangesAsync();
    }
}
}

public interface IVacacion1Service{
Task insertar(Vacacion1 input);
    IEnumerable <Vacacion1>? obtener();
   Task actualizar(Guid id, Vacacion1 input);
   Task eliminar(Guid id);
    }