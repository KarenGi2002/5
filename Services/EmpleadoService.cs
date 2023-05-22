using vacaciones.Models;
 namespace vacaciones.Services;


public class EmpleadoService: IEmpleadoService{
    //inyeccion de dependencias contex a la bd
    vacacionesContext context;

public EmpleadoService(vacacionesContext dbContext){
context= dbContext;
}


//CRUD
//CREATE- insertar a la base de datos
//async await cuando hay comunicacion fuera del codigo
public async Task insertar(Empleado inputEmpleado){
    inputEmpleado.EmpleadoId= Guid.NewGuid();
    await context.AddAsync(inputEmpleado);
    await context.SaveChangesAsync();
    }

    //READ-- Obtener de la db

public  IEnumerable<Empleado>? obtener(){
    return context.Empleado;
}
//UPDATE
public async Task actualizar (Guid id, Empleado inputEmpleado){
    var empleado= context.Empleado?.Find(id);

    if(empleado != null){
     empleado.nombre=inputEmpleado.nombre;
     empleado.fechaingreso= inputEmpleado.fechaingreso;
     empleado.cargoId= inputEmpleado.cargoId;
     empleado.disponible=inputEmpleado.disponible;

     await context.SaveChangesAsync();
    }
}
//delete
public async Task eliminar (Guid id){
    var empleado= context.Empleado?.Find(id);
    if(empleado != null){
     context.Remove(empleado);
     await context.SaveChangesAsync();
    }
}
}

public interface IEmpleadoService{
Task insertar(Empleado inputEmpleado);
    IEnumerable <Empleado>? obtener();
   Task actualizar(Guid id, Empleado empleado);
   Task eliminar(Guid id);
    }