using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController // Classe derivada de firstapibasecontroller e com isso eu gero as heranças para fazer um controle mais geral
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(GetCustomKey());
    }
}
