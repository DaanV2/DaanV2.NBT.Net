/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;


namespace DaanV2.NBT.Serialization; 
public static partial class NBTWriter {
    /// <summary>Writes the given nbtstructure into a file</summary>
    /// <param name="Filepath">The filepath to write to</param>
    /// <param name="Tag">The tag to write</param>
    /// <param name="compression">The compression type to be used</param>
    /// <param name="Endian">The Endian of the nbt structure</param>
    public static void WriteFile(String Filepath, ITag Tag, NBTCompression compression, Endian Endian) {
        var Writer = new FileStream(Filepath, FileMode.Create);

        Stream stream = CompressionStream.GetCompressionStream(Writer, compression);
        Write(Tag, new SerializationContext(Endian, stream));

        stream.Flush();
        stream.Close();
    }

    /// <summary>Writes the given nbtstructure into a file</summary>
    /// <param name="stream">The stream to write to</param>
    /// <param name="Tag">The tag to write</param>
    /// <param name="compression">The compression type to be used</param>
    /// <param name="Endian">The Endian of the nbt structure</param>
    public static void WriteFile(Stream stream, ITag Tag, NBTCompression compression, Endian Endian) {
        stream = CompressionStream.GetCompressionStream(stream, compression);

        Write(Tag, new SerializationContext(Endian, stream));
    }

    /// <summary>Writes the given nbtstructure into a file</summary>
    /// <param name="Filepath">The filepath to write to</param>
    /// <param name="Tag">The tag to write</param>
    /// <param name="Endian">The Endian of the nbt structure</param>
    public static void WriteFile(String Filepath, ITag Tag, Endian Endian = Endian.Little) {
        var Writer = new FileStream(Filepath, FileMode.Create);
        Write(Tag, new SerializationContext(Endian, Writer));

        Writer.Flush();
        Writer.Close();
    }
}
