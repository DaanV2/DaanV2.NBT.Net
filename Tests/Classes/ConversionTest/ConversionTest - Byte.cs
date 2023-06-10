using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test {

    public partial class ConversionTest {
        [TestMethod]
        public void ByteTest() {
            for (Byte I = 0; I < Byte.MaxValue; I++) {
                Assert.AreEqual(NBTCasting.ConvertTo<Byte>(I), I, "Byte to boolean casting didn't work");
            }
        }

        [TestMethod]
        public void ByteBooleanTest() {
            Assert.AreEqual(NBTCasting.ConvertTo<Boolean>((Byte)1), true, "Byte to boolean casting didn't work");
            Assert.AreEqual(NBTCasting.ConvertTo<Boolean>((Byte)0), false, "Byte to boolean casting didn't work");
        }

        [TestMethod]
        public void Int32Test() {
            for (Int32 I = Int32.MinValue; I < Int32.MaxValue / 2; I += Int32.MaxValue / 3) {
                Assert.AreEqual(NBTCasting.ConvertTo<Int32>(I) , I, "Int32 to boolean casting didn't work");
            }
        }

        [TestMethod]
        public void Int64Test() {
            for (Int64 I = Int64.MinValue; I < Int64.MaxValue / 2; I += Int64.MaxValue / 3) {
                Assert.AreEqual(NBTCasting.ConvertTo<Int64>(I) , I, "Int64 to boolean casting didn't work");
            }
        }
    }
}
