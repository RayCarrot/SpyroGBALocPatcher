using System.Linq;
using BinarySerializer;

namespace SpyroGBALocPatcher;

public class SpyroLoc : BinarySerializable
{
    public SpyroEncoding Pre_Encoding { get; set; }

    public ushort[] StringOffsets { get; set; }
    public byte[][] StringData { get; set; }

    public string[] Strings => StringData.Select(x => Pre_Encoding.GetString(x)).ToArray();

    public long SetStrings(string[] strings)
    {
        StringOffsets = new ushort[strings.Length];
        StringData = new byte[strings.Length][];

        ushort offset = (ushort)(strings.Length * 2);

        for (int i = 0; i < strings.Length; i++)
        {
            byte[] bytes = Pre_Encoding.GetBytes(strings[i]);
            
            StringOffsets[i] = offset;
            StringData[i] = bytes;

            offset = (ushort)(offset + bytes.Length + 1);
        }

        return offset;
    }

    public override void SerializeImpl(SerializerObject s)
    {
        int length = StringOffsets?.Length ?? 0;

        if (StringOffsets == null)
        {
            ushort firstOffset = s.DoAt(s.CurrentPointer, () => s.Serialize<ushort>(default, name: $"{nameof(StringOffsets)}[0]"));
            length = firstOffset / 2;
        }

        StringOffsets = s.SerializeArray<ushort>(StringOffsets, length, name: nameof(StringOffsets));

        StringData ??= new byte[length][];

        for (int i = 0; i < StringOffsets.Length; i++)
        {
            s.DoAt(Offset + StringOffsets[i], () =>
            {
                byte strLength = s.Serialize<byte>((byte)(StringData?.ElementAtOrDefault(i)?.Length ?? 0), name: $"{nameof(StringData)}[{i}].Length");
                StringData[i] = s.SerializeArray<byte>(StringData[i], strLength, name: $"{nameof(StringData)}[{i}]");
            });
        }
    }
}