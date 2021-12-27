using System;
using System.Linq;
using System.Text;

namespace SpyroGBALocPatcher;

public class SpyroEncoding : Encoding
{
    public SpyroEncoding(char[] fontTable)
    {
        FontTable = fontTable;
    }

    public char[] FontTable { get; }

    public override int GetByteCount(char[] chars, int index, int count) => count;

    public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
    {
        for (int i = charIndex; i < charCount; i++)
        {
            bytes[byteIndex] = (byte)Array.IndexOf(FontTable, chars[i]);
            byteIndex++;
        }

        return charCount;
    }

    public override int GetCharCount(byte[] bytes, int index, int count) => bytes.Skip(index).Take(count).Count(x => x != 0xFF);

    public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
    {
        for (int i = byteIndex; i < byteCount; i++)
        {
            if (bytes[i] == 0xFF)
                continue;

            chars[charIndex] = FontTable.ElementAtOrDefault(bytes[i]);
            charIndex++;
        }

        return byteCount;
    }

    public override int GetMaxByteCount(int charCount) => charCount;

    public override int GetMaxCharCount(int byteCount) => byteCount;
}