/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;

namespace DaanV2.NBT.Serialization.Serialization; 
/// <summary>A class that can read base types from the stream</summary>
internal partial class NBTTagBaseTypeReader : ITagReader {
    /// <summary>Gets the type for which this object can read</summary>
    private static readonly NBTTagType[] _ForType = new NBTTagType[] {
        NBTTagType.ByteArray,
        NBTTagType.IntArray,
        NBTTagType.LongArray,
        NBTTagType.Byte,
        NBTTagType.Short,
        NBTTagType.Int,
        NBTTagType.Long,
        NBTTagType.Double,
        NBTTagType.Float,
        NBTTagType.String,
        NBTTagType.End
    };

    /// <summary>Gets the type for which this object can read</summary>
    public NBTTagType[] ForType => _ForType;

    /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
    /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
    /// <param name="Context">The context that provides a buffer, the stream and Endian of the NBT</param>
    public void ReadContent(ITag tag, SerializationContext Context) {
        Stream Reader = Context.Stream;
        Int32 Length;

        switch (tag.Type) {
            //Arrays
            case NBTTagType.ByteArray:
                Length = Context.ReadInt32();
                tag.SetValue(Context.ReadBytes(Length));
                return;

            case NBTTagType.IntArray:
                Length = Context.ReadInt32();
                tag.SetValue(Context.ReadInt32Array(Length));
                return;

            case NBTTagType.LongArray:
                Length = Context.ReadInt32();
                tag.SetValue(Context.ReadInt64Array(Length));
                return;

            //Values
            case NBTTagType.Byte:
                tag.SetValue((Byte)Context.Stream.ReadByte());
                return;

            case NBTTagType.Short:
                tag.SetValue(Context.ReadInt16());
                return;

            case NBTTagType.Int:
                tag.SetValue(Context.ReadInt32());
                return;

            case NBTTagType.Long:
                tag.SetValue(Context.ReadInt64());
                return;

            case NBTTagType.Double:
                tag.SetValue(Context.ReadDouble());
                return;

            case NBTTagType.Float:
                tag.SetValue(Context.ReadFloat());
                return;

            case NBTTagType.String:
                tag.SetValue(NBTReader.ReadString(Reader, Context.Endian));
                return;
            case NBTTagType.Unknown:
            case NBTTagType.End:
            default:
                return;
        }
    }

    /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
    /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
    /// <param name="Context">The context that provides a buffer, the stream and Endian of the NBT</param>
    public void ReadHeader(ITag tag, SerializationContext Context) {
        tag.Name = NBTReader.ReadString(Context);
    }
}
