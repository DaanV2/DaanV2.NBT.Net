/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.IO;
using System.Text;

namespace DaanV2.NBT {
    public static partial class NBTReader {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reader"></param>
        /// <returns></returns>
        public static ITag Read(Stream Reader) {
            Int32 FirstByte = Reader.ReadByte();
            NBTTagType Type = (NBTTagType)FirstByte;
            string Name;
            Object Value;
            Int32 Length;

            switch (Type) {
                case NBTTagType.Byte:
                case NBTTagType.ByteArray:
                case NBTTagType.Double:
                case NBTTagType.Float:
                case NBTTagType.Int:
                case NBTTagType.IntArray:
                case NBTTagType.Long:
                case NBTTagType.LongArray:
                case NBTTagType.Short:
                case NBTTagType.String:
                    (Name, Value) = ReadNameAndValue(Reader, Type);
                    return NBTTagFactory.Create(Type, Name, Value);

                case NBTTagType.List:
                    Name = ReadName(Reader);
                    NBTTagType Subtype = (NBTTagType)Reader.ReadByte();
                    Length = Reader.ReadInt32();
                    NBTTagList List = new NBTTagList(Name, Subtype, Length);

                    for (Int32 I = 0; I < Length; I++) {
                        List[I] = Read(Reader);
                    }

                    return List;

                case NBTTagType.Compound:
                    Name = ReadName(Reader);
                    NBTTagCompound Com = new NBTTagCompound(Name, 10);
                    ITag Tag = Read(Reader);

                    while (Tag != null) {
                        Com.Add(Tag);
                        Tag = Read(Reader);
                    }

                    return Com;

                case NBTTagType.End:
                    return null;
                case NBTTagType.Unknown:
                default:
                    throw new InvalidDataException($"tag type of {Type} not recoginzed");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reader"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        private static (String Name, Object Value) ReadNameAndValue(Stream Reader, NBTTagType Type) {
            String Name = ReadName(Reader);
            Object Value = null;
            Int32 Length;

            switch (Type) {
                case NBTTagType.Byte:
                    return (Name, (Byte)Reader.ReadByte());

                case NBTTagType.ByteArray:
                    Length = Reader.ReadInt32();
                    return (Name, Reader.ReadByteArray(Length));

                case NBTTagType.Double:
                    return (Name, Reader.ReadDouble());

                case NBTTagType.Float:
                    return (Name, Reader.ReadFloat());

                case NBTTagType.Int:
                    return (Name, Reader.ReadInt32());

                case NBTTagType.IntArray:
                    Length = Reader.ReadInt32();
                    return (Name, Reader.ReadInt32Array(Length));

                case NBTTagType.Long:
                    return (Name, Reader.ReadInt64());

                case NBTTagType.LongArray:
                    Length = Reader.ReadInt32();
                    return (Name, Reader.ReadInt64Array(Length));

                case NBTTagType.Short:
                    return (Name, Reader.ReadInt16());

                case NBTTagType.String:
                    Length = Reader.ReadInt16();
                    return (Name, Encoding.UTF8.GetString(Reader.ReadBytes(Length)));
            }

            return (Name, Value);
        }
    }
}
