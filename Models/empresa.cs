namespace TP3_Arias.Models
{
    public static class empresa
    {
        public static List<disco> catalogo;

        public static void InicializarCatalogo()
        {
            catalogo = new List<disco>
            {
                // Álbum debut bajo Big Machine Records
                new disco(1, "Taylor Swift", "Taylor Swift", "Big Machine Records", "Country", "taylor_swift.jpg", new List<string>()),
                // Fearless TV en segunda posición (solo sello)
                new disco(8, "Fearless (Taylor's Version)", "Taylor Swift", "Republic Records", "Country", "fearless_tv.jpg", new List<string>()),
                // Speak Now TV
                new disco(2, "Speak Now (Taylor's Version)", "Taylor Swift", "Republic Records", "Country", "speak_now_tv.jpg", new List<string>()),
                // Red TV en cuarta posición
                new disco(9, "Red (Taylor's Version)", "Taylor Swift", "Republic Records", "Country/Pop", "red_tv.jpg", new List<string>()),
                // 1989 TV
                new disco(3, "1989 (Taylor's Version)", "Taylor Swift", "Republic Records", "Pop", "1989_tv.jpg", new List<string>()),
                // Reputation bajo Big Machine Records
                new disco(4, "Reputation", "Taylor Swift", "Big Machine Records", "Pop", "reputation.jpg", new List<string>()),
                // Lover bajo Republic Records
                new disco(5, "Lover", "Taylor Swift", "Republic Records", "Pop", "lover.jpg", new List<string>()),
                // Folklore bajo Republic Records
                new disco(6, "Folklore", "Taylor Swift", "Republic Records", "Indie Folk", "folklore.jpg", new List<string>()),
                // Evermore bajo Republic Records
                new disco(7, "Evermore", "Taylor Swift", "Republic Records", "Indie Folk", "evermore.jpg", new List<string>()),
                // Midnights bajo Republic Records
                new disco(10, "Midnights", "Taylor Swift", "Republic Records", "Pop", "midnights.jpg", new List<string>()),
                // The Tortured Poets Department bajo Republic Records
                new disco(11, "The Tortured Poets Department", "Taylor Swift", "Republic Records", "Pop", "the_tortured_poets_department.jpg", new List<string>()),
                // The Tortured Poets Department The Anthology bajo Republic Records
                new disco(12, "The Tortured Poets Department The Anthology", "Taylor Swift", "Republic Records", "Pop", "the_tortured_poets_department_anthology.jpg", new List<string>())
            };
        }
    }
}