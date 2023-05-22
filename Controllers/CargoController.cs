using Microsoft.AspNetCore.Mvc;
using vacaciones.Models;
using vacaciones.Services;

namespace vacaciones.Controllers;

//atributos controller

[ApiController]
[Route ("aapi/[Controller]")]
public class CargoController: ControllerBase{
    //inyeccion de dependencia

ICargoService cargoService;
public CargoController(ICargoService serviceCargo){
    cargoService=serviceCargo;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresarCargos([FromBody] Cargo nuevoCargo){
cargoService.insertar(nuevoCargo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrarCargos(){
    return Ok(cargoService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizarCargos([FromBody] Cargo cargoActualizar, Guid id){
cargoService.actualizar(id,cargoActualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminarCargos(Guid id){
cargoService.eliminar(id);
    return Ok();
}

}