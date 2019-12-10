using System;
using System.IO;

namespace DaanV2.NBT {
    public static partial class NBTWriter {
        ///DOLATER <summary>Add Description</summary>
        /// <param name=""></param>
        /// <param name="stream"></param>
        public static void Write(ITag tag, Stream stream) {
            WriteHeader(tag, stream);
            WritePayload(tag, stream);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="tag"></param>
        /// <param name="stream"></param>
        public static void WriteHeader(ITag tag, Stream stream) {

            switch (tag.Type) {
                case NBTTagType.List:
                    stream.WriteByte((Byte)tag.Type);
                    WriteString(stream, tag.Name);
                    stream.WriteByte((Byte)tag.GetInformation(NBTTagInformation.ListSubtype));
                    stream.WriteInt32((Int32)tag.GetInformation(NBTTagInformation.ListSize));

                    return;
                case NBTTagType.Byte:
                case NBTTagType.ByteArray:
                case NBTTagType.Compound:
                case NBTTagType.Double:
                case NBTTagType.Float:
                case NBTTagType.Int:
                case NBTTagType.IntArray:
                case NBTTagType.Long:
                case NBTTagType.LongArray:
                case NBTTagType.Short:
                case NBTTagType.String:
                    stream.WriteByte((Byte)tag.Type);
                    WriteString(stream, tag.Name);

                    return;
                case NBTTagType.End:
                    stream.WriteByte((Byte)tag.Type);

                    return;
                case NBTTagType.Unknown:
                default:
                    return;
            }
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="tag"></param>
        /// <param name="stream"></param>
        public static void WritePayload(ITag tag, Stream stream) {
            switch (tag.Type) {
                //Arrays
                case NBTTagType.ByteArray:
                    Byte[] Bytes = tag.GetValue<Byte[]>();
                    stream.WriteInt32(Bytes.Length);
                    stream.WriteBytes(Bytes);

                    return;
                case NBTTagType.IntArray:
                    Int32[] Ints = tag.GetValue<Int32[]>();
                    stream.WriteInt32(Ints.Length);
                    stream.WriteInt32Array(Ints);

                    return;
                case NBTTagType.LongArray:
                    Int64[] Longs = tag.GetValue<Int64[]>();
                    stream.WriteInt32(Longs.Length);
                    stream.WriteInt64Array(Longs);

                    return;

                //Values
                case NBTTagType.Byte:
                    stream.WriteByte(tag.GetValue<Byte>());
                    return;

                case NBTTagType.Short:
                    stream.WriteInt16(tag.GetValue<Int16>());
                    return;

                case NBTTagType.Int:
                    stream.WriteInt32(tag.GetValue<Int32>());
                    return;

                case NBTTagType.Long:
                    stream.WriteInt64(tag.GetValue<Int64>());
                    return;

                case NBTTagType.Double:
                    stream.WriteDouble(tag.GetValue<Double>());
                    return;

                case NBTTagType.Float:
                    stream.WriteFloat(tag.GetValue<Single>());
                    return;

                case NBTTagType.String:
                    WriteString(stream, tag.GetValue<String>());
                    return;

                case NBTTagType.Compound:
                    for (Int32 I = 0; I < tag.Count; I++) {
                        Write(tag[I], stream);
                    }
                    stream.WriteByte((Byte)NBTTagType.End);

                    return;
                case NBTTagType.List:
                    for (Int32 I = 0; I < tag.Count; I++) {
                        WritePayload(tag[I], stream);
                    }

                    return;
                case NBTTagType.End:
                case NBTTagType.Unknown:
                default:
                    return;
            }
        }
    }
}
