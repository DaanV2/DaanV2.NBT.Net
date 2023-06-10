/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using System.Runtime.CompilerServices;


namespace DaanV2.NBT.Serialization; 
public static partial class NBTReader {
    /// <summary>Reads the content of the given file</summary>
    /// <param name="Filepath">The file to read from</param>
    /// <param name="Endian">The Endian of the nbt structure</param>
    /// <param name="Compression">The compression type used</param>
    /// <returns>Reads the content of the given file</returns>
    public static ITag ReadFile(String Filepath, Endian Endian, NBTCompression Compression = NBTCompression.Auto) {
        Stream Stream = CompressionStream.GetDecompressionStream(new FileStream(Filepath, FileMode.Open, FileAccess.ReadWrite), Compression);
        ITag Out = ReadFile(new SerializationContext(Endian, Stream));
        Stream.Close();

        return Out;
    }

    /// <summary>Reads the content of the given file</summary>
    /// <param name="stream">The stream to read from</param>
    /// <param name="Endian">The Endian of the nbt structure</param>
    /// <returns>Reads the content of the given file</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ITag ReadFile(Stream stream, Endian Endian) {
        return Read(stream, Endian);
    }

    /// <summary>Reads the content of the given file</summary>
    /// <param name="Context">The context to read from</param>
    /// <returns>Reads the content of the given file</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ITag ReadFile(SerializationContext Context) {
        return Read(Context);
    }
}