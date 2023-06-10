namespace DaanV2.NBT;
public static partial class CompressionStream {
    /// <summary>Detect which compression has been used</summary>
    /// <param name="stream">The stream to read from</param>
    /// <returns>Detect which compression has been used</returns>
    public static NBTCompression DetectCompression(Stream stream) {
        if (!stream.CanSeek) {
            throw new ArgumentException($"{nameof(stream)} must be able to seek");
        }

        Int32 Temp = (Byte)stream.ReadByte();
        stream.Seek(-1, SeekOrigin.Current);

        //Byte is a nbt tag type
        if (Temp is >= 0 and <= 12) {
            return NBTCompression.None;
        }

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
