using System.Data;
namespace Patrimonio.Dominio;

public class Client 
{
    public Client(int id, string nome, DateTime nascimento)
    {
        Id = id;
        Nome = nome;
        Nascimento = nascimento;
    }
    
    public int Id { get; set; }

    public string? Nome { get; set; }
    
    public DateTime Nascimento { get; set; }
}