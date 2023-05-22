using Microsoft.AspNetCore.Mvc;
using vacaciones.Models;
using vacaciones.Services;

namespace vacaciones.Controllers;

//atributos controller

[ApiController]
[Route("api/[controller]")]
public class EmpleadoController: ControllerBase{

//inyecion de dependencia
IEmpleadoService empleadoService;
public EmpleadoController(IEmpleadoService serviceEmpleado){
empleadoService= serviceEmpleado;
}
//CRUD
//atributos de endpoints
//create
[HttpPost]
public IActionResult ingresarEmpleados([FromBody] Empleado nuevoEmpleado){
    empleadoService.insertar(nuevoEmpleado);
    return Ok("Datos ingresados");
}

[HttpGet]
public IActionResult mostrarEmpleados(){

   return Ok(empleadoService.obtener());
   
}


[HttpPut("{id}")]
public IActionResult actualizarEmpleados([FromBody] Empleado  empleadoActualizar, Guid id ){
   empleadoService.actualizar(id, empleadoActualizar);
    return Ok("Datos actualizados");
}

[HttpDelete ("{id}")]
public IActionResult eliminarEmpleados(Guid id){
    empleadoService.eliminar(id);
    return Ok("Datos eliminados");
}


}