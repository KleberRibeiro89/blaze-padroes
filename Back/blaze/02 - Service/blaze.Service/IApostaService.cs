namespace Blaze.Service;

public interface IApostaService
{
    Task SincronizarAsync();

    Task BuscarTodasApostas();

    Task BuscarPadrao3();
}
