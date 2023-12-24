using ScreenSound.Modelos;
using System.Linq;

namespace ScreenSound.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas
                .Select(generos => generos.Genero)
                .Distinct()
                .ToList();

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"-  {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas
                .Where(musica => musica.Genero
                .Contains(genero))
                .Select(musica => musica.Artista)
                .ToList()
                .Distinct();
            
            Console.WriteLine($"Exibindo os artistas por genêro musical >>> {genero}");

            var artistasOrdenados = artistasPorGeneroMusical.
                OrderBy
                (artista => artista).
                ToList();

            foreach (var artistas in artistasOrdenados)
            {
                Console.WriteLine($"-- {artistas}");
            }
        }

        public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
        {
            var musicasPorArtista = musicas.Where(musica => musica.Artista
            .Equals(artista))
                .Select(musica => musica.Nome)
                .ToList()
                .Distinct(); // Quando queremos um conjunto de uma lista, utilizamos o where
            
            Console.WriteLine($"Exibindo as músicas do artista {artista}");

            foreach (var musica in musicasPorArtista)
            {
                Console.WriteLine($"-- {musica}");
            }
        }

        public static void FiltraTonalidadeCSharp(List<Musica> musicas)
        {
            var tonalidadePorMusica = musicas.Where(musica => musica
            .Tonalidade.Equals("C#"))
                .Select(musica => musica.Nome)
                .ToList()
                .Distinct();
            Console.WriteLine($"Músicas em C#");

            foreach (var musica in tonalidadePorMusica)
            {
                Console.WriteLine($"-- {musica}");
            }
        }
    }
}