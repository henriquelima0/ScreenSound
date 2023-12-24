using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;

using (HttpClient client = new HttpClient()) // Inicializando e utilizando o HttpClient para fazer requisições HTTP
{
    try
    {
        // Fazendo uma requisição assíncrona para obter uma string JSON de uma URL
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // Desserializando a string JSON para uma lista de objetos Musica
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // JsonSerializer para transformar JSON em Objeto

        // Operações de filtro e ordenação comentadas

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); 
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "R&B");
        // LinqFilter.FiltrarMusicasPorArtista(musicas, "DJ");
        // LinqFilter.FiltraTonalidadeCSharp(musicas);


        // Criando uma instância da classe MusicasPreferidas e adicionando algumas músicas favoritas
        var musicasHenrique = new MusicasPreferidas("Henrique");
        musicasHenrique.AdicionaMusicasFavoritas(musicas[11]);
        musicasHenrique.AdicionaMusicasFavoritas(musicas[45]);
        musicasHenrique.AdicionaMusicasFavoritas(musicas[35]);
        musicasHenrique.AdicionaMusicasFavoritas(musicas[125]);
        musicasHenrique.AdicionaMusicasFavoritas(musicas[898]);

        // Exibindo as músicas favoritas e gerando um arquivo JSON
        musicasHenrique.ExibirMusicasFavoritas();
        musicasHenrique.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        // Lidando com exceções, caso ocorram durante a execução do bloco try
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}
