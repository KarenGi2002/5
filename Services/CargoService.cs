using vacaciones.Models;
namespace vacaciones.Services;

public class CargoService: ICargoService{
    //inyeccion de dependencia a la base de datos
vacacionesContext context;

public CargoService(vacacionesContext dbContext){
  context= dbContext;
}

    //CRUD
    //CREATE
    //ASYNC AWAIT

    public async Task insertar(Cargo inputCargo){
        inputCargo.CargoId=Guid.NewGuid();
        await context.AddAsync(inputCargo);
        await context.SaveChangesAsync();
    }

    public IEnumerable <Cargo>? obtener(){
        return context.Cargo;
    }
    public async Task actualizar (Guid id, Cargo inputCargo){
        var cargo=  context.Cargo?.Find(id);

        if(cargo != null){
            cargo.nombre=inputCargo.nombre;

            await context.SaveChangesAsync();

        }
    }
    public async Task eliminar(Guid id){
        var cargo=context.Cargo?.Find(id);
        if(cargo != null){
            context.Remove(cargo);
            await context.SaveChangesAsync();
        }
    }
}

public interface ICargoService{
    Task insertar (Cargo inputCargo);
    IEnumerable<Cargo>? obtener();
    Task actualizar(Guid id, Cargo cargo);
    Task eliminar(Guid id);
}