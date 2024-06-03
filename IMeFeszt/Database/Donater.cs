using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace IMeFeszt.Database;

[PrimaryKey(nameof(Name), nameof(Email))]
public class Donater
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public int Amount { get; set; }
}