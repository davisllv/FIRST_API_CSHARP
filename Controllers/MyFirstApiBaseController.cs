using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;
[Route("api/[controller]")] // Permite, caso eu queira, mudar a rota em um local
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase // Classe derivada de ControllerBase; C# não permite heranças múltiplas; É direto de heranças como filhos, netos, bisnetos e, no bisneto, eu consigo ter acesso o familiar mais alto
{
    // Privado - Somente aquela classe possui acesso
    // Protected - Somente as classes que são derivadas desta classe
    public string Author { get; set; } = "Davi da Silva";
    [HttpGet("heathy")] // Apenas colocar o método vai dar conflito com as rotas
    public IActionResult Heathy()
    {
        // Dessa forma todos os métodos irão ter esse método; bem como irá criar para todo mundo;
        // Para evitar essa instância desse método é preciso colocar abstract, pois o c# vai evitar 
        return Ok("It's Working");
    }

    protected string GetCustomKey()
    {
        // Todo método público ele considerará que é um endpoint
        // Caso eu coloque protected ele passará a ser um método mesmo
        return Request.Headers["MyKey"].ToString();
    }
}
