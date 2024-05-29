using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Model;

public class User
{
    public int ID { get; set; }
    public string Recept  { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string Photo { get; set; }
    public string Sposob { get; set; }
}