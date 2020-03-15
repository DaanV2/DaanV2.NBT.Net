using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test {
    public partial class NBTTagFactoryTest {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tag"></param>
        /// <param name="Name"></param>
        /// <param name="Type"></param>
        public static void TestTag(ITag Tag, String Name, NBTTagType Type) {
            Assert.IsTrue(Tag.Name == Name, "Tag had wrong name");
            Assert.IsTrue(Tag.Type == Type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tag"></param>
        /// <param name="InformationTests"></param>
        public static void TestTagInformation(ITag Tag, params (NBTTagInformation Information, Object Value)[] InformationTests) {
            Int32 Length = InformationTests.Length;

            for (Int32 I = 0; I < Length; I++) {
                Assert.IsTrue(Tag.GetInformation(InformationTests[I].Information) == InformationTests[I].Value, $"{InformationTests[I].Information} received wrong value");
            }
        }
    }
}
