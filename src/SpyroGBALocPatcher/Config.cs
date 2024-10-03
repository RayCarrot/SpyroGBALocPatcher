namespace SpyroGBALocPatcher;

public class Config
{
    public string ROMFilePath { get; set; }
    public string TextFilePath { get; set; }
    public long LocAddress { get; set; }
    public long LocLength { get; set; }
    public char[] Font { get; set; }

    public static char[] DefaultFont_Spyro1 => new[]
    {
        ' ', '!', '"', '%', '&', '\'', '(', ')', ',', '-', '.', '/',
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        ':', ';', '?',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        '¡', '©', '¿', 'Á', 'Ä', 'Ç', 'È', 'É', 'Ì', 'Í', 'Ñ', 'Ó', 'Ö', 'Ú', 'Ü',
        'ß', 'à', 'á', 'â', 'ä', 'ç', 'è', 'é', 'ê', 'ì', 'í', 'î', 'ï', 'ñ', 'ò', 'ó', 'ô', 'ö', 'ù', 'ú', 'û', 'ü'
    };
    public static char[] DefaultFont_Spyro2EU => new[]
    {
        ' ', '!', '"', '%', '&', '\'', '(', ')', ',', '-', '.', '/',
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        ':', ';', '?',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        '¡', '©', '¿', 'Á', 'Ä', 'Ç', 'È', 'É', 'Ì', 'Í', 'Ñ', 'Ó', 'Ö', 'Ú', 'Ü',
        'ß', 'à', 'á', 'â', 'ä', 'ç', 'è', 'é', 'ê', 'ì', 'í', 'î', 'ï', 'ñ', 'ò', 'ó', 'ô', 'ö', 'ù', 'ú', 'û', 'ü'
    };
    public static char[] DefaultFont_Spyro2US => new[]
    {
        ' ', '!', '"', '%', '&', '\'', '(', ')', ',', '-', '.', '/',
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        ':', ';', '?',
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
        ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
        ' ', ' ', ' ', ' ', ' ', ' ', 'é'
    };

    public static (string Name, Config Config)[] GetDefaults()
    {
        return new[]
        {
            // Season of Ice (EU)
            ("Ice_EU_English", new Config
            {
                ROMFilePath = "Season of Ice (EU).gba",
                TextFilePath = "Season of Ice (EU - English).json",
                LocAddress = 0x08273afc,
                LocLength = 26652,
                Font = DefaultFont_Spyro1,
            }),
            ("Ice_EU_French", new Config
            {
                ROMFilePath = "Season of Ice (EU).gba",
                TextFilePath = "Season of Ice (EU - French).json",
                LocAddress = 0x0827a318,
                LocLength = 29268,
                Font = DefaultFont_Spyro1,
            }),
            ("Ice_EU_Spanish", new Config
            {
                ROMFilePath = "Season of Ice (EU).gba",
                TextFilePath = "Season of Ice (EU - Spanish).json",
                LocAddress = 0x0828156c,
                LocLength = 29004,
                Font = DefaultFont_Spyro1,
            }),
            ("Ice_EU_German", new Config
            {
                ROMFilePath = "Season of Ice (EU).gba",
                TextFilePath = "Season of Ice (EU - German).json",
                LocAddress = 0x082886b8,
                LocLength = 30720,
                Font = DefaultFont_Spyro1,
            }),
            ("Ice_EU_Italian", new Config
            {
                ROMFilePath = "Season of Ice (EU).gba",
                TextFilePath = "Season of Ice (EU - Italian).json",
                LocAddress = 0x0828feb8,
                LocLength = 29068,
                Font = DefaultFont_Spyro1,
            }),

            // Season of Ice (US)
            ("Ice_US_English", new Config
            {
                ROMFilePath = "Season of Ice (US).gba",
                TextFilePath = "Season of Ice (US - English).json",
                LocAddress = 0x08270434,
                LocLength = 26652,
                Font = DefaultFont_Spyro1,
            }),

            // Season of Flame (EU)
            ("Flame_EU_English", new Config
            {
                ROMFilePath = "Season of Flame (EU).gba",
                TextFilePath = "Season of Flame (EU - English).json",
                LocAddress = 0x08180130,
                LocLength = 47288,
                Font = DefaultFont_Spyro2EU,
            }),
            ("Flame_EU_French", new Config
            {
                ROMFilePath = "Season of Flame (EU).gba",
                TextFilePath = "Season of Flame (EU - French).json",
                LocAddress = 0x0818b9e8,
                LocLength = 50444,
                Font = DefaultFont_Spyro2EU,
            }),
            ("Flame_EU_Spanish", new Config
            {
                ROMFilePath = "Season of Flame (EU).gba",
                TextFilePath = "Season of Flame (EU - Spanish).json",
                LocAddress = 0x08197ef4,
                LocLength = 50200,
                Font = DefaultFont_Spyro2EU,
            }),
            ("Flame_EU_German", new Config
            {
                ROMFilePath = "Season of Flame (EU).gba",
                TextFilePath = "Season of Flame (EU - German).json",
                LocAddress = 0x081a430c,
                LocLength = 51996,
                Font = DefaultFont_Spyro2EU,
            }),
            ("Flame_EU_Italian", new Config
            {
                ROMFilePath = "Season of Flame (EU).gba",
                TextFilePath = "Season of Flame (EU - Italian).json",
                LocAddress = 0x081b0e28,
                LocLength = 50936,
                Font = DefaultFont_Spyro2EU,
            }),

            // Season of Flame (US)
            ("Flame_US_English", new Config
            {
                ROMFilePath = "Season of Flame (US).gba",
                TextFilePath = "Season of Flame (US - English).json",
                LocAddress = 0x0817fde4,
                LocLength = 48140,
                Font = DefaultFont_Spyro2US,
            }),
        };
    }
}
