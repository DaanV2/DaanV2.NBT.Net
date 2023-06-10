/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;


namespace DaanV2.NBT.Serialization; 
public static partial class NBTWriter {
    /// <summary>Writes the given tag into a stream</summary>
    /// <param name="tag">The tag to write</param>
    /// <param name="stream">The stream to write to</param>
    /// <param name="Endian">The Endian of the data</param>
    public static void Write(ITag tag, Stream stream, Endian Endian = Endian.Little) {
        var Context = new SerializationContext(Endian, stream);
        Write(tag, Context);
    }

    /// <summary>Writes the given tag into a stream</summary>
    /// <param name="tag">The tag to write</param>
    /// <param name="Context">The context to write to</param>
    public static void Write(ITag tag, SerializationContext Context) {
        NBTWriter._Writers.TryGetValue(tag.Type, out ITagWriter Writer);

        if (Writer is null) {
            throw new Exception($"No ITagWriter found for: {tag.Type}");
        }

        Writer.WriteHeader(tag, Context);
        Writer.WriteContent(tag, Context);
    }

    /// <summary>Writes the given tag's header into a stream</summary>
    /// <param name="tag">The tag to write</param>
    /// <param name="Context">The context to write to</param>
    public static void WriteHeader(ITag tag, SerializationContext Context) {
        NBTWriter._Writers.TryGetValue(tag.Type, out ITagWriter Writer);

        if (Writer is null) {
            throw new Exception($"No ITagWriter found for: {tag.Type}");
        }

        Writer.WriteHeader(tag, Context);
    }

    /// <summary>Writes the given tag's content into a stream</summary>
    /// <param name="tag">The tag to write</param>
    /// <param name="Context">The context to write to</param>
    public static void WriteContent(ITag tag, SerializationContext Context) {
        NBTWriter._Writers.TryGetValue(tag.Type, out ITagWriter Writer);

        if (Writer is null) {
            throw new Exception($"No ITagWriter found for: {tag.Type}");
        }

        Writer.WriteContent(tag, Context);
    }
}
