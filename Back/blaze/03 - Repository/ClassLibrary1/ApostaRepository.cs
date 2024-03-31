using Microsoft.EntityFrameworkCore;

namespace Blaze.Repository;

internal class ApostaRepository : IApostaRepository
{
    private readonly AppDbContext _context;
    public ApostaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Adicionar(List<Aposta> apostas)
    {
        var idsBlaze = apostas.Select(x=>x.BlazeId).ToList();
        await _context.Apostas.AddRangeAsync(apostas);
        await _context.SaveChangesAsync();
    }

    public async Task Adicionar(Aposta aposta)
    {
        _context.Add(aposta);
        await _context.SaveChangesAsync();
    }

    public async Task<DateTime> BuscarRegistroMaisRecente()
    {
        return await _context.Apostas.MaxAsync(a => a.DataAposta);
    }
}
