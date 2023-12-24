using ScreenSound.Modelos;

namespace ScreenSound.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List <Musica> musicas) 
        {
            var artistasOrdenados = musicas.
                OrderBy(musicas => musicas.Artista)
                .ToList()
                .Select(musica => musica.Artista)
                .Distinct();

            Console.WriteLine("Lista de artistas ordenados");

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }

    }
}
