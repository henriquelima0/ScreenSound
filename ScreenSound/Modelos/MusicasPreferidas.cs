using System.Text.Json;

namespace ScreenSound.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; set; }

        public MusicasPreferidas(string nome) {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }  

        public void AdicionaMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são suas músicas preferidas --> {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($" Artista: {musica.Artista}");
                Console.WriteLine($" Música: {musica.Nome}");
                Console.WriteLine($" Genêro: {musica.Genero}");
                Console.WriteLine($" Popularidade: {musica.PopularidadeS}");
                Console.WriteLine($" Tonalidade: {musica.Tonalidade}");
            }
            Console.WriteLine("");
        }

        public void GerarArquivoJson() // transformando nossos objetos em json
        {
            string json = JsonSerializer.Serialize(new { 
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
            });

            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquivo .Json gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
