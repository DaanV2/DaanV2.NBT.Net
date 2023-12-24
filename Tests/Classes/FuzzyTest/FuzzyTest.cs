using System;
using System.IO;
using DaanV2.NBT.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test;
[TestClass]
public partial class NBTFuzzyTest {


    [TestMethod]
    [DataRow(1339913606, NBTCompression.None, Endian.Little)]
    [DataRow(1339913606, NBTCompression.None, Endian.Big)]
    [DataRow(1339913606, NBTCompression.Auto, Endian.Little)]
    [DataRow(1339913606, NBTCompression.Gzip, Endian.Little)]
    [DataRow(1339913606, NBTCompression.Zlib, Endian.Little)]
    public void FuzzyTest(Int32 Seed, NBTCompression compression, Endian endian) {
        var R = new Random(Seed);
        NBTTagCompound data = NBTFuzzyTest.Create(R);

        //Serialize
        var stream = new MemoryStream();
        NBTWriter.WriteFile(stream, data, compression, endian);

        //Deserialize
        Byte[] bytes = stream.ToArray();
        stream = new MemoryStream(bytes);
        Stream reader = CompressionStream.GetDecompressionStream(stream, NBTCompression.Auto);
        ITag data2 = NBTReader.ReadFile(reader, endian);

        //Compare
        Assert.IsTrue(data.Equals(data2));
    }

    [TestMethod]
    [DataRow(209602537)]
    [DataRow(1703668700)]
    [DataRow(685935817)]
    [DataRow(1669746090)]
    [DataRow(1554815738)]
    [DataRow(1030592101)]
    [DataRow(1494828806)]
    [DataRow(1450365360)]
    [DataRow(583193317)]
    [DataRow(571897801)]
    public void SimpleFuzzyTest(Int32 Seed) {
        this.FuzzyTest(Seed, NBTCompression.None, Endian.Little);
    }

}
