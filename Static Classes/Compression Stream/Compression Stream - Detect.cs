using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    public static partial class CompressionStream {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public static NBTCompression DetectCompression(Stream stream) {
            if (!stream.CanSeek)
                throw new ArgumentException($"{nameof(stream)} must be able to seek");

            Int32 Temp = (Byte)stream.ReadByte();
            stream.Seek(-1, SeekOrigin.Current);

            //Byte is a nbt tag type
            if (Temp >= 0 && Temp <= 12)
                return NBTCompression.None;

            //Magical numbers
            switch (Temp) {
                case 0x1F:
                    return NBTCompression.Gzip;

                case 0x78:
                    return NBTCompression.Zlib;

                case -1:
                    throw new EndOfStreamException();

                default:
                    throw new InvalidDataException("compression type is not recoginzed");
            }
        }
    }
}
