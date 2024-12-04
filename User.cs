namespace MyFirstApi;

public sealed class User : Pessoa // Sealed faz com que seja impossível ser uma classe base das demais. Bloqueio as possíveis heranças
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string GetBrand()
    {
        // override - Sobscrita a função da classe pai
        // Classe implementada por causa da abstract da outra classe
        throw new NotImplementedException();
    }

    public bool GetModel()
    {
        return IsConected();
    }

}
