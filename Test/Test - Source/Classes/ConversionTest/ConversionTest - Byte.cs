using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test {

    public partial class ConversionTest {
        [TestMethod]
        public void ByteTest() {
            Assert.IsTrue(NBTCasting.ConvertTo<Boolean>((Byte)1) == true, "Byte to boolean casting didn't work");
            Assert.IsTrue(NBTCasting.ConvertTo<Boolean>((Byte)0) == false, "Byte to boolean casting didn't work");

            for (Byte I = 0; I < Byte.MaxValue; I++) {
                Assert.IsTrue(NBTCasting.ConvertTo<Byte>(I) == I, "Byte to boolean casting didn't work");
            }
        }
    }
}
