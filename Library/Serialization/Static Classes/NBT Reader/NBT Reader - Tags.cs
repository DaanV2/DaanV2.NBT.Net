using System.Runtime.CompilerServices;


namespace DaanV2.NBT.Serialization;
public static partial class NBTReader {
    /// <summary>Reads the NBTTag from the given stream</summary>
    /// <param name="stream">The stream to read from</param>
    /// <param name="Endian">the Endian of the NBT structure</param>
    /// <returns>Reads the NBTTag from the given stream</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ITag? Read(Stream stream, Endian Endian) {
        return Read(new SerializationContext(Endian, stream));
    }

    /// <summary>Reads the NBTTag from the given stream</summary>
    /// <param name="Context">The context to read from</param>
    /// <returns>Reads the NBTTag from the given stream</returns>
    public static ITag? Read(SerializationContext Context) {
        ITag? Receiver = null;

        try {
            Int32 FirstByte = Context.Stream.ReadByte();
            if (FirstByte == -1) {
                return null;
            }

            var Type = (NBTTagType)FirstByte;
            Receiver = NBTTagFactory.Create(Type);

            if (Type is NBTTagType.End or NBTTagType.Unknown) {
                return Receiver;
            }

            _ = NBTReader._Readers.TryGetValue(Type, out ITagReader? Reader);

            if (Reader is null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadHeader(Receiver, Context);
            Reader.ReadContent(Receiver, Context);
        }
        catch (DeserializationException e) {
            throw e;
        }
        catch (Exception e) {
            throw new DeserializationException(Receiver?.Name, Receiver?.Type ?? NBTTagType.Unknown, Context.Stream.Position, e);
        }

        return Receiver;
    }

    /// <summary>Reads the header of the given tag</summary>
    /// <param name="Type">The type to read</param>
    /// <param name="Context">The context needed to read from</param>
    /// <param name="Receiver">The receing tag</param>
    public static void ReadHeader(NBTTagType Type, SerializationContext Context, ITag Receiver) {
        NBTReader._Readers.TryGetValue(Type, out ITagReader Reader);

        if (Reader is null) {
            throw new Exception($"No ITagWriter found for: {Type}");
        }

        Reader.ReadHeader(Receiver, Context);
    }

    /// <summary>Reads the content of the given tag</summary>
    /// <param name="Type">The type to read</param>
    /// <param name="Context">The context needed to read from</param>
    /// <param name="Receiver">The receing tag</param>
    public static void ReadContent(NBTTagType Type, SerializationContext Context, ITag Receiver) {
        NBTReader._Readers.TryGetValue(Type, out ITagReader Reader);

        if (Reader is null) {
            throw new Exception($"No ITagWriter found for: {Type}");
        }

        Reader.ReadContent(Receiver, Context);
    }
}