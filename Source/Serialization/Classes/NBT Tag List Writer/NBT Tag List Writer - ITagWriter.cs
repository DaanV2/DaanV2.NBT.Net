/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;

namespace DaanV2.NBT.Serialization.Serialization {
    /// <summary>The class that write an nbt tag list into the stream</summary>
    internal partial class NBTTagListWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.List };

        /// <summary>Gets the type for which this object can write</summary>
        public NBTTagType[] ForType => _ForType;

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context to write to</param>
        public void WriteHeader(ITag tag, SerializationContext Context) {
            Context.Stream.WriteByte((Byte)tag.Type);

            NBTWriter.WriteString(Context, tag.Name);

            Context.Stream.WriteByte((Byte)tag.GetInformation(NBTTagInformation.ListSubtype));
            Context.WriteInt32((Int32)tag.GetInformation(NBTTagInformation.ListSize));
        }

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context to write to</param>
        public static void WriteHeader(NBTTagList tag, SerializationContext Context) {
            Context.Stream.WriteByte((Byte)tag.Type);

            NBTWriter.WriteString(Context, tag.Name);

            Context.Stream.WriteByte((Byte)tag.SubType);
            Context.WriteInt32((Int32)tag.Count);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context to write to</param>
        public void WriteContent(ITag tag, SerializationContext Context) {
            Object O = tag.GetInformation(NBTTagInformation.ListSubtype);

            if (O == null) {
                throw new Exception("Cannot read list sub type");
            }

            var SubTagType = (NBTTagType)O;
            ITagWriter Writer = NBTWriter.GetWriter(SubTagType);

            if (Writer == null) {
                throw new Exception($"Cannot find writer for {SubTagType}");
            }

            Int32 Count = tag.Count;
            if (SubTagType == NBTTagType.List) {
                for (Int32 I = 0; I < Count; I++) {
                    ITag Item = tag[I];
                    Context.Stream.WriteByte((Byte)Item.GetInformation(NBTTagInformation.ListSubtype));
                    Context.WriteInt32((Int32)Item.GetInformation(NBTTagInformation.ListSize));
                    Writer.WriteContent(Item, Context);
                }
            }
            else {
                for (Int32 I = 0; I < Count; I++) {
                    Writer.WriteContent(tag[I], Context);
                }
            }
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context to write to</param>
        public static void WriteContent(NBTTagList tag, SerializationContext Context) {
            NBTTagType SubTagType = tag.SubType;
            ITagWriter Writer = NBTWriter.GetWriter(SubTagType);

            if (Writer == null) {
                throw new Exception($"Cannot find writer for {SubTagType}");
            }

            Int32 Count = tag.Count;
            if (SubTagType == NBTTagType.List) {
                /*SubTag = new NBTTagList(SubTagType);
                SubTag.SetInformation(NBTTagInformation.ListSubtype, (NBTTagType)Context.Stream.ReadByte());
                SubTag.SetInformation(NBTTagInformation.ListSize, Context.ReadInt32());
                Reader.ReadContent(SubTag, Context);
                tag[I] = SubTag;*/
                Context.Stream.WriteByte((Byte)tag.GetInformation(NBTTagInformation.ListSubtype));
                Context.WriteInt32((Int32)tag.GetInformation(NBTTagInformation.ListSize));

            }
            else {
                for (Int32 I = 0; I < Count; I++) {
                    Writer.WriteContent(tag[I], Context);
                }
            }
        }
    }
}
