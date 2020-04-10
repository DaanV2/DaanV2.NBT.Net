using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test {
    public partial class NBTTagFactoryTest {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="Tag">FILL IN</param>
        /// <param name="Name">The name of the instance</param>
        /// <param name="Type">FILL IN</param>
        public static void TestTag(ITag Tag, String Name, NBTTagType Type) {
            Assert.IsTrue(Tag.Name == Name, "Tag had wrong name");
            Assert.IsTrue(Tag.Type == Type);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Tag">FILL IN</param>
        /// <param name="InformationTests">FILL IN</param>
        public static void TestTagInformation(ITag Tag, params (NBTTagInformation Information, Object Value)[] InformationTests) {
            Int32 Length = InformationTests.Length;

            for (Int32 I = 0; I < Length; I++) {
                Assert.IsTrue(Tag.GetInformation(InformationTests[I].Information) == InformationTests[I].Value, $"{InformationTests[I].Information} received wrong value");
            }
        }
    }
}
