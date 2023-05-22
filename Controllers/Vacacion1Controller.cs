using Microsoft.AspNetCore.Mvc;
using vacaciones.Models;
using vacaciones.Services;

namespace vacaciones.Controllers;

//atributos controller

[ApiController]
[Route("api/[controller]")]
public class Vacacion1Controller: ControllerBase{

//inyecion de dependencia
IVacacion1Service vacacionService;
public Vacacion1Controller(IVacacion1Service servicevacacion){
vacacionService= servicevacacion;
}
//CRUD
//atributos de endpoints
//create
[HttpPost]
public IActionResult ingresar([FromBody] Vacacion1 nuevo){
    vacacionService.insertar(nuevo);
    return Ok("Datos ingresados");
}

[HttpGet]
public IActionResult mostrar(){

   return Ok(vacacionService.obtener());
   
}


[HttpPut("{id}")]
public IActionResult actualizar([FromBody] Vacacion1  Actualizar, Guid id ){
   vacacionService.actualizar(id, Actualizar);
    return Ok("Datos actualizados");
}

[HttpDelete ("{id}")]
public IActionResult eliminar(Guid id){
    vacacionService.eliminar(id);
    return Ok("Datos eliminados");
}


}