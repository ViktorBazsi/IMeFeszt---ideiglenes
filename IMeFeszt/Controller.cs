using IMeFeszt.Database;
using Microsoft.AspNetCore.Mvc;

namespace IMeFeszt;

[ApiController]
[Route("donate")]
public class Controller(AppDbContext dbContext) : ControllerBase
{
    [HttpPut("{name}/{email}/{message}/{amount:int}")]
    public async Task<int> AddNewDonater(string name, string email, string message, int amount)
    {
        dbContext.Donaters.Add(new Donater {Name = name, Email = email, Message = message, Amount = amount});
        await dbContext.SaveChangesAsync();
        return dbContext.Donaters.Sum(d=>d.Amount);
    }
    
    [HttpGet]
    public async Task<int> GetDonatedAmount()
    {
        return dbContext.Donaters.Sum(d=>d.Amount);
    }
}