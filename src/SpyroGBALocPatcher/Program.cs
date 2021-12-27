using System;
using System.IO;
using BinarySerializer;

namespace SpyroGBALocPatcher;

public class Program
{
    public static void Main(string[] args)
    {
        if ((args.Length != 2 || args[0] is not "-i" and not "-e") &&
            (args.Length != 1 || args[0] is not "-g"))
        {
            Console.WriteLine("The Spyro GBA Localization Patcher can be used to either import or export the localization:");
            Console.WriteLine("");
            Console.WriteLine("Generate config files: -g");
            Console.WriteLine("Import:                -i configFilePath");
            Console.WriteLine("Export:                -e configFilePath");
            Console.WriteLine("");
            Console.WriteLine("Please check the readme for more instructions");
            return;
        }

        if (args[0] == "-g")
        {
            foreach (var c in Config.GetDefaults())
                JsonHelpers.SerializeToFile(c.Config, $"{c.Name}.json");

            Console.WriteLine("Config files have been generated");
            return;
        }

        bool import = args[0] == "-i";

        Config config = JsonHelpers.DeserializeFromFile<Config>(args[1]);

        string basePath = Path.GetDirectoryName(config!.ROMFilePath);
        string romFile = Path.GetFileName(config.ROMFilePath);

        using Context context = new(basePath);

        context.AddFile(new MemoryMappedFile(context, romFile, 0x08000000)
        {
            RecreateOnWrite = false,
        });

        SpyroEncoding encoding = new(config.Font);
        Pointer locPointer = new Pointer(config.LocAddress, context.GetFile(romFile));

        // Import
        if (import)
        {
            string[] text = JsonHelpers.DeserializeFromFile<string[]>(config.TextFilePath);

            SpyroLoc loc = new()
            {
                Pre_Encoding = encoding
            };

            long length = loc.SetStrings(text);

            if (config.LocLength != -1 && length > config.LocLength)
            {
                Console.WriteLine($"Localization length {length} exceeds the specified max");
                return;
            }

            FileFactory.Write(locPointer, loc, context);

            Console.WriteLine("Localization has been imported");
        }
        // Export
        else
        {
            SpyroLoc loc = FileFactory.Read<SpyroLoc>(locPointer, context, (_, x) => x.Pre_Encoding = encoding);

            JsonHelpers.SerializeToFile(loc.Strings, config.TextFilePath);
            Console.WriteLine("Localization has been exported");
        }
    }
}