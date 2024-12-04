namespace MyFirstApi;

// Abstract em Classe - Impossibilita a instancia de uma classe;
// Abstract em função ou propriedade - A classe precisa ser abstract
public abstract class Pessoa
{
    // Somente tenho acesso nas classes ou lugares que herdam essa classe diretamente
    protected bool IsConected() => true;
    public abstract string GetBrand(); // Torna obrigatório essa implementação nas classes que derivam dela. Devido ao abstract

    // Virtual torna possível o override, ou seja, a sobescrita das demais classes.
    public virtual string Hello()
    {
        return "Hello World";
    }
}
