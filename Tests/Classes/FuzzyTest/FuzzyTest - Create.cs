using System;
using DaanV2.NBT.Builders;

namespace DaanV2.NBT.Test;

public partial class NBTFuzzyTest {

    public static NBTTagCompound Create(Random R) {
        var compound = new CompoundBuilder("root");

        //Boolean
        compound.Add(R.NextString(), R.NextBool());
        //Byte
        compound.Add(R.NextString(), R.NextByte());
        //Short
        compound.Add(R.NextString(), R.NextShort());
        //Int
        compound.Add(R.NextString(), R.NextInt());
        //Long
        compound.Add(R.NextString(), R.NextLong());
        //Float
        compound.Add(R.NextString(), R.NextFloat());
        //Double
        compound.Add(R.NextString(), R.NextDouble());
        //String
        compound.Add(R.NextString(), R.NextString());

        //Byte Array
        compound.Add(R.NextString(), R.NextByteArray());
        //Int Array
        compound.Add(R.NextString(), R.NextIntArray());
        //Long Array
        compound.Add(R.NextString(), R.NextLongArray());

        //List
        ListBuilder list = compound.AddSubList(R.NextString(), NBTTagType.Int);
        for (Int32 I = 0; I < R.Next(10); I++) {
            list.Add(R.NextInt());
        }

        return compound.GetResult();
    }
}
