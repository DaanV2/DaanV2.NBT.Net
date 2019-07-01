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
            if (FirstByte == -1) return default;

            NBTTagType Type = (NBTTagType)FirstByte;
            ITag Out = NBTTagFactory.Create(Type);

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
                case NBTTagType.List:
                case NBTTagType.Compound:
                    ReadHeader(Type, Reader, Out);
                    ReadPayload(Type, Reader, Out);

                    return Out;
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
        private static void ReadHeader(NBTTagType Type, Stream Reader, ITag Receiver) {

            switch (Type) {
                case NBTTagType.List:
                    Receiver.Name = ReadString(Reader);
                    Receiver.SetInformation(NBTTagInformation.ListSubtype, (NBTTagType)Reader.ReadByte());
                    Receiver.SetInformation(NBTTagInformation.ListSize, Reader.ReadInt32());
                    break;

                case NBTTagType.Compound:
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
                    Receiver.Name = ReadString(Reader);
                    break;

                case NBTTagType.End:
                case NBTTagType.Unknown:
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Tag"></param>
        private static void ReadPayload(NBTTagType Type, Stream Reader, ITag Receiver) {
            Int32 Length;
            ITag SubTag;

            switch (Type) {
                //Arrays
                case NBTTagType.ByteArray:
                    Length = Reader.ReadInt32();
                    Receiver.SetValue(Reader.ReadByteArray(Length));
                    return;

                case NBTTagType.IntArray:
                    Length = Reader.ReadInt32();
                    Receiver.SetValue(Reader.ReadInt32Array(Length));
                    return;

                case NBTTagType.LongArray:
                    Length = Reader.ReadInt32();
                    Receiver.SetValue(Reader.ReadInt64Array(Length));
                    return;

                //Values
                case NBTTagType.Byte:
                    Receiver.SetValue((Byte)Reader.ReadByte());
                    return;

                case NBTTagType.Short:
                    Receiver.SetValue(Reader.ReadInt16());
                    return;

                case NBTTagType.Int:
                    Receiver.SetValue(Reader.ReadInt32());
                    return;

                case NBTTagType.Long:
                    Receiver.SetValue(Reader.ReadInt64());
                    return;

                case NBTTagType.Double:
                    Receiver.SetValue(Reader.ReadDouble());
                    return;

                case NBTTagType.Float:
                    Receiver.SetValue(Reader.ReadFloat());
                    return;

                case NBTTagType.String:
                    Receiver.SetValue(ReadString(Reader));
                    return;

                //Special
                case NBTTagType.List:
                    Object O = Receiver.GetInformation(NBTTagInformation.ListSubtype);
                    if (O == null) throw new Exception("List returned no subtype");
                    NBTTagType SubTagType = (NBTTagType)O;

                    for (Int32 I = 0; I < Receiver.Count; I++) {
                        SubTag = NBTTagFactory.Create(SubTagType);
                        Receiver[I] = SubTag;
                        ReadPayload(SubTagType, Reader, SubTag);
                    }

                    return;
                case NBTTagType.Compound:
                    SubTag = Read(Reader);

                    while (SubTag != null) {
                        Receiver.Add(SubTag);
                        SubTag = Read(Reader);
                    }

                    return;
                case NBTTagType.Unknown:
                case NBTTagType.End:
                default:
                    return;
            }
        }
    }
}