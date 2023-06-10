/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;

namespace DaanV2.NBT.Serialization.Serialization; 
/// <summary>The type writer for all basic types</summary>
internal partial class NBTTagBaseTypeWriter : ITagWriter {
    /// <summary>Gets the type for which this object can write</summary>
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

    /// <summary>Gets the type for which this object can write</summary>
    public NBTTagType[] ForType => _ForType;


    /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
    /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
    /// <param name="Context">The context that provides a buffer, the stream and Endian of the NBT</param>
    public void WriteHeader(ITag tag, SerializationContext Context) {
        Context.Stream.WriteByte((Byte)tag.Type);
        NBTWriter.WriteString(Context, tag.Name);
    }

    /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
    /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
    /// <param name="Context">The context that provides a buffer, the stream and Endian of the NBT</param>
    public void WriteContent(ITag tag, SerializationContext Context) {
        switch (tag.Type) {
            //Arrays
            case NBTTagType.ByteArray:
                Byte[] Bytes = tag.GetValue<Byte[]>();
                Context.WriteBytes(Bytes);

                return;
            case NBTTagType.IntArray:
                Int32[] Ints = tag.GetValue<Int32[]>();
                Context.WriteInt32Array(Ints);

                return;
            case NBTTagType.LongArray:
                Int64[] Longs = tag.GetValue<Int64[]>();
                Context.WriteInt64Array(Longs);

                return;

            //Values
            case NBTTagType.Byte:
                Context.Stream.WriteByte(tag.GetValue<Byte>());
                return;

            case NBTTagType.Short:
                Context.WriteInt16(tag.GetValue<Int16>());
                return;

            case NBTTagType.Int:
                Context.WriteInt32(tag.GetValue<Int32>());
                return;

            case NBTTagType.Long:
                Context.WriteInt64(tag.GetValue<Int64>());
                return;

            case NBTTagType.Double:
                Context.WriteDouble(tag.GetValue<Double>());
                return;

            case NBTTagType.Float:
                Context.WriteFloat(tag.GetValue<Single>());
                return;

            case NBTTagType.String:
                NBTWriter.WriteString(Context.Stream, tag.GetValue<String>(), Context.Endian);

                return;
            case NBTTagType.End:
            case NBTTagType.Unknown:
            default:
                return;
        }
    }
}
