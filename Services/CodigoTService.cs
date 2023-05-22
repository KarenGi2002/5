using vacaciones.Models;
 namespace vacaciones.Services;


public class CodigoTService: ICodigoTService{
    //inyeccion de dependencias contex a la bd
    vacacionesContext context;

public CodigoTService(vacacionesContext dbContext){
context= dbContext;
}


//CRUD
//CREATE- insertar a la base de datos
//async await cuando hay comunicacion fuera del codigo
public async Task insertar(CodigoTrabajo input){
    input.CodigoTId= Guid.NewGuid();
    await context.AddAsync(input);
    await context.SaveChangesAsync();
    }

    //READ-- Obtener de la db

public  IEnumerable<CodigoTrabajo>? obtener(){
    return context.CodigoTrabajo;
}
//UPDATE
public async Task actualizar (Guid id, CodigoTrabajo input){
    var c= context.CodigoTrabajo?.Find(id);

    if(c != null){
    c.antiguedad= input.antiguedad;
    c.diasOtorgados=input.diasOtorgados;
    c.vigente=input.vigente;
     await context.SaveChangesAsync();
    }
}
//delete
public async Task eliminar (Guid id){
    var c= context.CodigoTrabajo?.Find(id);
    if(c != null){
     context.Remove(c);
     await context.SaveChangesAsync();
    }
}
}

public interface ICodigoTService{
Task insertar(CodigoTrabajo input);
    IEnumerable <CodigoTrabajo>? obtener();
   Task actualizar(Guid id, CodigoTrabajo input);
   Task eliminar(Guid id);
    }