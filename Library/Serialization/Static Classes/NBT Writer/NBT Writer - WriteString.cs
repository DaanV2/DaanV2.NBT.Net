using System.Runtime.CompilerServices;
using System.Text;


namespace DaanV2.NBT.Serialization;

public static partial class NBTWriter {
    /// <summary>Writes a string into the stream</summary>
    /// <param name="Writer">The stream to write to</param>
    /// <param name="Text">The text to write</param>
    /// <param name="Endian">The Endian of the nbt structure</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteString(Stream Writer, String Text, Endian Endian) {
        Byte[] Bytes = Encoding.UTF8.GetBytes(Text);
        Int16 value = (Int16)Bytes.Length;

        if (value < 0 || value != Bytes.Length) {
            throw new ArgumentException("String is too long");
        }

        Writer.WriteInt16(value, Endian);
        Writer.WriteBytes(Bytes);
    }

    /// <summary>Writes a string into the stream</summary>
    /// <param name="Context">The context to write to</param>
    /// <param name="Text">The text to write away</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteString(SerializationContext Context, String Text) {
        WriteString(Context.Stream, Text, Context.Endian);
    }
}