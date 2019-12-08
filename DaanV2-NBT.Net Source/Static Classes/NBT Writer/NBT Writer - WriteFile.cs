using System;
using System.IO;

namespace DaanV2.NBT {
    public static partial class NBTWriter {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="Filepath"></param>
        /// <param name="Object"></param>
        /// <param name="compression"></param>
        public static Stream WriteFile(String Filepath, ITag Tag, NBTCompression compression) {
            FileStream Writer = new FileStream(Filepath, FileMode.Create);
            Stream stream = WriteFile(Writer, Tag, compression);
            stream.Flush();
            stream.Close();
            return stream;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Filepath"></param>
        /// <param name="Object"></param>
        /// <param name="compression"></param>
        public static Stream WriteFile(Stream stream, ITag Tag, NBTCompression compression) {
            stream = CompressionStream.GetCompressionStream(stream, compression);

            Write(Tag, stream);
            return stream;
        }
    }
}
