using Microsoft.AspNetCore.Mvc;
using vacaciones.Models;
using vacaciones.Services;

namespace vacaciones.Controllers;

//atributos controller

[ApiController]
[Route ("aapi/[Controller]")]
public class CodigoTController: ControllerBase{
    //inyeccion de dependencia

ICodigoTService codigoService;
public CodigoTController(ICodigoTService serviceCodigo){
    codigoService=serviceCodigo;
}

 //Crud 
 //ATRIBUTOS DE ENDPOINTS
 //CREATE
 [HttpPost]
 public IActionResult ingresar([FromBody] CodigoTrabajo nuevo){
codigoService.insertar(nuevo);
    return Ok("Datos guardados");
 }   

 [HttpGet]
 public IActionResult mostrar(){
    return Ok(codigoService.obtener());
 }
 [HttpPut("{id}")]
 public IActionResult actualizarCargos([FromBody] CodigoTrabajo Actualizar, Guid id){
codigoService.actualizar(id,Actualizar);
    return Ok("Datos actualizados");

 }
[HttpDelete("{id}")]
public IActionResult eliminar(Guid id){
codigoService.eliminar(id);
    return Ok();
}

}