namespace Blaze.Repository;

public interface IApostaRepository
{
    Task<DateTime> BuscarRegistroMaisRecente();

    Task Adicionar(List<Aposta> apostas);

    Task Adicionar(Aposta aposta);
}
