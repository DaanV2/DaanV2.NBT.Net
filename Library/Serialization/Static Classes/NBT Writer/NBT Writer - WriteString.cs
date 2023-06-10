using System;
using System.IO;
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
        Writer.WriteInt16((Int16)Bytes.Length, Endian);
        Writer.WriteBytes(Bytes);
    }

    /// <summary>Writes a string into the stream</summary>
    /// <param name="Context">The context to write to</param>
    /// <param name="Text">The text to write away</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteString(SerializationContext Context, String Text) {
        Byte[] Bytes = Encoding.UTF8.GetBytes(Text);
        Context.Stream.WriteInt16((Int16)Bytes.Length, Context.Endian);
        Context.Stream.WriteBytes(Bytes);
    }
}