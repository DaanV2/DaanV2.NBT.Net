using System;

namespace DaanV2.NBT.Test;

///DOLATER <summary>add description for class: RandomExtension</summary>
public static partial class RandomExtension {


    public static String NextString(this Random R) {
        return NextString(R, 100);
    }

    public static String NextString(this Random R, Int32 maxLength) {
        Int32 length = R.Next(1, maxLength);
        Byte[] bytes = new Byte[length / 2];

        R.NextBytes(bytes);
        //To hex
        return BitConverter.ToString(bytes).Replace("-", "");
    }

    public static Boolean NextBool(this Random R) {
        return R.Next(100) >= 50;
    }

    public static Byte NextByte(this Random R) {
        return (Byte)R.Next(0, 256);
    }

    public static Int16 NextShort(this Random R) {
        return (Int16)R.Next(0, 65536);
    }

    public static Int32 NextInt(this Random R) {
        return R.Next();
    }

    public static Int64 NextLong(this Random R) {
        Span<Byte> bytes = stackalloc Byte[sizeof(Int64)];
        R.NextBytes(bytes);
        return BitConverter.ToInt64(bytes);
    }

    public static Single NextFloat(this Random R) {
        return (Single)R.NextDouble();
    }

    public static Byte[] NextByteArray(this Random R) {
        Int32 length = R.Next(1, 100);
        Byte[] bytes = new Byte[length];

        R.NextBytes(bytes);
        return bytes;
    }

    public static Int32[] NextIntArray(this Random R) {
        Int32 length = R.Next(1, 100);
        Int32[] bytes = new Int32[length];

        for (Int32 I = 0; I < length; I++) {
            bytes[I] = R.Next();
        }

        return bytes;
    }

    public static Int64[] NextLongArray(this Random R) {
        Int32 length = R.Next(1, 100);
        Int64[] bytes = new Int64[length];

        for (Int32 I = 0; I < length; I++) {
            bytes[I] = R.NextLong();
        }

        return bytes;
    }

}
