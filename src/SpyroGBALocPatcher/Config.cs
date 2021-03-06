using System.Collections.Generic;

namespace SpyroGBALocPatcher;

public class Config
{
    public string ROMFilePath { get; set; }
    public string TextFilePath { get; set; }
    public long LocAddress { get; set; }
    public long LocLength { get; set; }
    public char[] Font { get; set; }

    public static char[] DefaultFont_Spyro1 => new char[]
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

    public static IEnumerable<(string Name, Config Config)> GetDefaults()
    {
        yield return ("Ice_EU_English", new Config
        {
            ROMFilePath = "Season of Ice (EU).gba",
            TextFilePath = "Season of Ice (EU - English).json",
            LocAddress = 0x08273afc,
            LocLength = 26652,
            Font = DefaultFont_Spyro1,
        });

        yield return ("Ice_EU_French", new Config
        {
            ROMFilePath = "Season of Ice (EU).gba",
            TextFilePath = "Season of Ice (EU - French).json",
            LocAddress = 0x0827a318,
            LocLength = 29268,
            Font = DefaultFont_Spyro1,
        });

        yield return ("Ice_EU_Spanish", new Config
        {
            ROMFilePath = "Season of Ice (EU).gba",
            TextFilePath = "Season of Ice (EU - Spanish).json",
            LocAddress = 0x0828156c,
            LocLength = 29004,
            Font = DefaultFont_Spyro1,
        });

        yield return ("Ice_EU_German", new Config
        {
            ROMFilePath = "Season of Ice (EU).gba",
            TextFilePath = "Season of Ice (EU - German).json",
            LocAddress = 0x082886b8,
            LocLength = 30720,
            Font = DefaultFont_Spyro1,
        });
            
        yield return ("Ice_EU_Italian", new Config
        {
            ROMFilePath = "Season of Ice (EU).gba",
            TextFilePath = "Season of Ice (EU - Italian).json",
            LocAddress = 0x0828feb8,
            LocLength = 29068,
            Font = DefaultFont_Spyro1,
        });

        yield return ("Ice_US_English", new Config
        {
            ROMFilePath = "Season of Ice (US).gba",
            TextFilePath = "Season of Ice (US - English).json",
            LocAddress = 0x08270434,
            LocLength = 26652,
            Font = DefaultFont_Spyro1,
        });
    }
}