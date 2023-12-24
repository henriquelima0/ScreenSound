using System.Text.Json.Serialization;

namespace ScreenSound.Modelos
{
    internal class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("popularity")]
        public string? Popularidade { get; set; }

        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string Tonalidade
        {
            get
            {
                return tonalidades[Key];
            }
        }
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duracao em se   gundos: {Duracao / 1000}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Popularidade: {PopularidadeS}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }

        public int PopularidadeS
        {
            get
            {
                return int.Parse(Popularidade!);
            }
        }
    }
}
