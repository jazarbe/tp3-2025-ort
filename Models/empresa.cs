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
                new disco(0, "Taylor Swift", "Taylor Swift", "Big Machine Records", "Country", "taylor_swift.jfif", new List<string>()
                {
                    "Tim McGraw",
                    "Picture To Burn",
                    "Teardrops On My Guitar",
                    "A Place In This World",
                    "Cold As You",
                    "The Outside",
                    "Tied Together With A Smile",
                    "Stay Beautiful",
                    "Should've Said No",
                    "Mary's Song (Oh My My My)",
                    "Our Song",
                    "I'm Only Me When I'm With You",
                    "Invisible",
                    "A Perfectly Good Heart",
                    "Teardrops On My Guitar - Pop Version"
                }),
                // Fearless TV en segunda posición (solo sello)
                new disco(1, "Fearless (Taylor's Version)", "Taylor Swift", "Republic Records", "Country", "fearless_tv.webp", new List<string>()
                {
                    "Fearless (Taylor's Version)",
                    "Fifteen (Taylor's Version)",
                    "Love Story (Taylor's Version)",
                    "Hey Stephen (Taylor's Version)",
                    "White Horse (Taylor's Version)",
                    "You Belong With Me (Taylor's Version)",
                    "Breathe (Taylor's Version)",
                    "Tell Me Why (Taylor's Version)",
                    "You're Not Sorry (Taylor's Version)",
                    "The Way I Loved You (Taylor's Version)",
                    "Forever & Always (Taylor's Version)",
                    "The Best Day (Taylor's Version)",
                    "Change (Taylor's Version)",
                    "Jump Then Fall (Taylor's Version)",
                    "Untouchable (Taylor's Version)",
                    "Forever & Always (Piano Version) (Taylor's Version)",
                    "Come In With the Rain (Taylor's Version)",
                    "Superstar (Taylor's Version)",
                    "The Other Side Of The Door (Taylor's Version)",
                    "Today Was A Fairytale (Taylor's Version)",
                    "You All Over Me (Taylor's Version)",
                    "Mr. Perfectly Fine (Taylor's Version) (From The Vault)",
                    "We Were Happy (Taylor's Version) (From The Vault)",
                    "That's When (Taylor's Version) (From The Vault)",
                    "Don't You (Taylor's Version) (From The Vault)",
                    "Bye Bye Baby (Taylor's Version) (From The Vault)"
                }),
                // Speak Now TV
                new disco(2, "Speak Now (Taylor's Version)", "Taylor Swift", "Republic Records", "Country", "speak_now_tv.webp", new List<string>()
                {
                    "Mine (Taylor's Version)",
                    "Sparks Fly (Taylor's Version)",
                    "Back To December (Taylor's Version)",
                    "Speak Now (Taylor's Version)",
                    "Dear John (Taylor's Version)",
                    "Mean (Taylor's Version)",
                    "The Story Of Us (Taylor's Version)",
                    "Never Grow Up (Taylor's Version)",
                    "Enchanted (Taylor's Version)",
                    "Better Than Revenge (Taylor's Version)",
                    "Innocent (Taylor's Version)",
                    "Haunted (Taylor's Version)",
                    "Last Kiss (Taylor's Version)",
                    "Long Live (Taylor's Version)",
                    "Ours (Taylor's Version)",
                    "Superman (Taylor's Version)",
                    "Electric Touch (Taylor's Version) (From The Vault)",
                    "When Emma Falls In Love (Taylor's Version) (From The Vault)",
                    "I Can See You (Taylor's Version) (From The Vault)",
                    "Castles Crumbling (Taylor's Version) (From The Vault)",
                    "Foolish One (Taylor's Version) (From The Vault)",
                    "Timeless (Taylor's Version) (From The Vault)"
                }),
                // Red TV en cuarta posición
                new disco(3, "Red (Taylor's Version)", "Taylor Swift", "Republic Records", "Country/Pop", "red_tv.webp", new List<string>()
                {
                    "State Of Grace (Taylor's Version)",
                    "Red (Taylor's Version)",
                    "Treacherous (Taylor's Version)",
                    "I Knew You Were Trouble (Taylor's Version)",
                    "All Too Well (Taylor's Version)",
                    "22 (Taylor's Version)",
                    "I Almost Do (Taylor's Version)",
                    "We Are Never Ever Getting Back Together (Taylor's Version)",
                    "Stay Stay Stay (Taylor's Version)",
                    "The Last Time (Taylor's Version)",
                    "Holy Ground (Taylor's Version)",
                    "Sad Beautiful Tragic (Taylor's Version)",
                    "The Lucky One (Taylor's Version)",
                    "Everything Has Changed (Taylor's Version)",
                    "Starlight (Taylor's Version)",
                    "Begin Again (Taylor's Version)",
                    "The Moment I Knew (Taylor's Version)",
                    "Come Back...Be Here (Taylor's Version)",
                    "Girl At Home (Taylor's Version)",
                    "State Of Grace (Acoustic Version) (Taylor's Version)",
                    "Ronan (Taylor's Version)",
                    "Better Man (Taylor's Version) (From The Vault)",
                    "Nothing New (Taylor's Version) (From The Vault)",
                    "Babe (Taylor's Version) (From The Vault)",
                    "Message In A Bottle (Taylor's Version) (From The Vault)",
                    "I Bet You Think About Me (Taylor's Version) (From The Vault)",
                    "Forever Winter (Taylor's Version) (From The Vault)",
                    "Run (Taylor's Version) (From The Vault)",
                    "The Very First Night (Taylor's Version) (From The Vault)",
                    "All Too Well (10 Minute Version) (Taylor's Version) (From The Vault)"
                }),
                // 1989 TV
                new disco(4, "1989 (Taylor's Version)", "Taylor Swift", "Republic Records", "Pop", "1989_tv.jpg", new List<string>()
                {
                    "Welcome To New York (Taylor's Version)",
                    "Blank Space (Taylor's Version)",
                    "Style (Taylor's Version)",
                    "All You Had To Do Was Stay (Taylor's Version)",
                    "Out Of The Woods (Taylor's Version)",
                    "Shake It Off (Taylor's Version)",
                    "I Wish You Would (Taylor's Version)",
                    "Bad Blood (Taylor's Version)",
                    "Wildest Dreams (Taylor's Version)",
                    "How You Get The Girl (Taylor's Version)",
                    "This Love (Taylor's Version)",
                    "I Know Places (Taylor's Version)",
                    "Clean (Taylor's Version)",
                    "Wonderland (Taylor's Version)",
                    "You Are In Love (Taylor's Version)",
                    "New Romantics (Taylor's Version)",
                    "\"Slut!\" (Taylor's Version) (From The Vault)",
                    "Say Don't Go (Taylor's Version) (From The Vault)",
                    "Now That We Don't Talk (Taylor's Version) (From The Vault)",
                    "Suburban Legends (Taylor's Version) (From The Vault)",
                    "Is It Over Now? (Taylor's Version) (From The Vault)"
                }),
                // Reputation bajo Big Machine Records
                new disco(5, "Reputation", "Taylor Swift", "Big Machine Records", "Pop", "reputation.jfif", new List<string>()
                {
                    "...Ready For It?",
                    "End Game",
                    "I Did Something Bad",
                    "Don't Blame Me",
                    "Delicate",
                    "Look What You Made Me Do",
                    "So It Goes...",
                    "Gorgeous",
                    "Getaway Car",
                    "King Of My Heart",
                    "Dancing With Our Hands Tied",
                    "Dress",
                    "This Is Why We Can't Have Nice Things",
                    "Call It What You Want",
                    "New Year's Day"
                }),
                // Lover bajo Republic Records
                new disco(6, "Lover", "Taylor Swift", "Republic Records", "Pop", "lover.jfif", new List<string>()
                {
                    "I Forgot That You Existed",
                    "Cruel Summer",
                    "Lover",
                    "The Man",
                    "The Archer",
                    "I Think He Knows",
                    "Miss Americana & The Heartbreak Prince",
                    "Paper Rings",
                    "Cornelia Street",
                    "Death By A Thousand Cuts",
                    "London Boy",
                    "Soon You'll Get Better",
                    "False God",
                    "You Need To Calm Down",
                    "Afterglow",
                    "ME!",
                    "It's Nice To Have A Friend",
                    "Daylight"
                }),
                // Folklore bajo Republic Records
                new disco(7, "Folklore", "Taylor Swift", "Republic Records", "Indie Folk", "folklore.jfif", new List<string>()
                {
                    "the 1",
                    "cardigan",
                    "the last great american dynasty",
                    "exile",
                    "my tears ricochet",
                    "mirrorball",
                    "seven",
                    "august",
                    "this is me trying",
                    "illicit affairs",
                    "invisible string",
                    "mad woman",
                    "epiphany",
                    "betty",
                    "peace",
                    "hoax",
                    "the lakes"
                }),
                // Evermore bajo Republic Records
                new disco(8, "Evermore", "Taylor Swift", "Republic Records", "Indie Folk", "evermore.webp", new List<string>()
                {
                    "willow",
                    "champagne problems",
                    "gold rush",
                    "tis the damn season",
                    "tolerate it",
                    "no body, no crime",
                    "happiness",
                    "dorothea",
                    "coney island",
                    "ivy",
                    "cowboy like me",
                    "long story short",
                    "marjorie",
                    "closure",
                    "evermore",
                    "right where you left me",
                    "it's time to go"
                }),
                // Midnights bajo Republic Records
                new disco(9, "Midnights", "Taylor Swift", "Republic Records", "Pop", "midnights.webp", new List<string>()
                {
                    "Lavender Haze",
                    "Maroon",
                    "Anti Hero",
                    "Snow On The Beach (feat. Lana del Rey)",
                    "You're On Your Own Kid",
                    "Midnight Rain",
                    "Question...?",
                    "Vigilante Shit",
                    "Bejeweled",
                    "Labyrinth",
                    "Karma",
                    "Sweet Nothing",
                    "Mastermind",
                    "The Great War",
                    "Bigger Than The Whole Sky",
                    "Paris",
                    "High Infidelity",
                    "Glitch",
                    "Would've, Could've, Should've",
                    "Dear Reader"
                }),
                // The Tortured Poets Department bajo Republic Records
                new disco(10, "The Tortured Poets Department", "Taylor Swift", "Republic Records", "Pop", "ttpd.webp", new List<string>()
                {
                    "Fortnight (feat. Post Malone)",
                    "The Tortured Poets Department",
                    "My Boy Only Breaks His Favourite Toys",
                    "Down Bad",
                    "So Long, London",
                    "But Daddy I Love Him",
                    "Fresh Out The Slammer",
                    "Florida!!! (fet. Florence + The Machine)",
                    "Guilty as Sin?",
                    "Who's Afraid of Little Old Me?",
                    "I Can Fix Him (No Really I Can)",
                    "loml",
                    "I Can Do It With a Broken Heart",
                    "The Smallest Man Who Ever Lived",
                    "The Alchemy",
                    "Clara Bow"
                }),
                // The Tortured Poets Department The Anthology bajo Republic Records
                new disco(11, "The Tortured Poets Department The Anthology", "Taylor Swift", "Republic Records", "Pop", "ttpd_anthology.jfif", new List<string>()
                {
                    "Fortnight (feat. Post Malone)",
                    "The Tortured Poets Department",
                    "My Boy Only Breaks His Favourite Toys",
                    "Down Bad",
                    "So Long, London",
                    "But Daddy I Love Him",
                    "Fresh Out The Slammer",
                    "Florida!!! (fet. Florence + The Machine)",
                    "Guilty as Sin?",
                    "Who's Afraid of Little Old Me?",
                    "I Can Fix Him (No Really I Can)",
                    "loml",
                    "I Can Do It With a Broken Heart",
                    "The Smallest Man Who Ever Lived",
                    "The Alchemy",
                    "Clara Bow",
                    "The Black Dog",
                    "imgonnagetyouback",
                    "The Albatross",
                    "Chloe or Sam or Sophia or Marcus",
                    "How Did It End?",
                    "So High School",
                    "I Hate It Here",
                    "thanK you aIMee",
                    "I Look in People's Windows",
                    "The Prophecy",
                    "Cassandra",
                    "Peter",
                    "The Bolter",
                    "Robin",
                    "The Manuscript"
                })
            };
        }
    }
}