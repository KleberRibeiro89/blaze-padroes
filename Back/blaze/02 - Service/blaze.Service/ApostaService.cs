using System.Runtime.InteropServices;
using System.Text.Json;
using Blaze.Repository;
using Blaze.Service;
using Blaze.Service.Model.Response;
using Microsoft.Extensions.Configuration;

namespace blaze.Service;

public class ApostaService : IApostaService
{
    private readonly HttpClient _httpClient;
    private readonly IApostaRepository _repository;
    public ApostaService(
        HttpClient httpClient,
        IApostaRepository repository)
    {
        _httpClient = httpClient;
        _repository = repository;
    }

    public Task BuscarPadrao3()
    {
        throw new NotImplementedException();
    }

    public Task BuscarTodasApostas()
    {
        throw new NotImplementedException();
    }

    public async Task SincronizarAsync()
    {
        int pagina = 1;
        var apiBlaze = $"{_httpClient.BaseAddress}startDate={DateTime.Today.AddDays(-10):yyyy-MM-dd}&endDate={DateTime.Now:yyyy-MM-dd}&page={pagina}";

        var result = await _httpClient.GetAsync(apiBlaze);

        string responseBody = await result.Content.ReadAsStringAsync();

        var registros = JsonSerializer.Deserialize<BlazeResponse>(responseBody);

        while (pagina < registros.TotalPages)
        {
            var apostas = registros.Itens.Select(a => new Aposta
            {
                BlazeId = a.Id,
                Cor = a.Cor,
                DataAposta = a.DataCriacao,
                Numero = a.Numero,
                Id = Guid.NewGuid()
            }).ToList();
            pagina++;


            await _repository.Adicionar(apostas);

        }

        throw new NotImplementedException();
    }
}
