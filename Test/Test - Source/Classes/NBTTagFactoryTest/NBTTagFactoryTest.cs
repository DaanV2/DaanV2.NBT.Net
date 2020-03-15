using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test {
    [TestClass]
    public partial class NBTTagFactoryTest {

        public const String DefaultName = "0123456789abcdefghijklmnopqrstuvwxyz";

        [TestMethod]
        public void TestCreateByte() {
            ITag Tag = NBTTagFactory.Create(DefaultName, false);
            TestTag(Tag, DefaultName, NBTTagType.Byte);

            Tag = NBTTagFactory.Create(DefaultName, (Byte)1);
            TestTag(Tag, DefaultName, NBTTagType.Byte);
        }

        [TestMethod]
        public void TestCreateInt16() {
            ITag Tag = NBTTagFactory.Create(DefaultName, (Int16)128);
            TestTag(Tag, DefaultName, NBTTagType.Short);
        }

        [TestMethod]
        public void TestCreateInt32() {
            ITag Tag = NBTTagFactory.Create(DefaultName, 128);
            TestTag(Tag, DefaultName, NBTTagType.Int);
        }

        [TestMethod]
        public void TestCreateInt64() {
            ITag Tag = NBTTagFactory.Create(DefaultName, (Int64)128);
            TestTag(Tag, DefaultName, NBTTagType.Long);
        }

        [TestMethod]
        public void TestCreateFloat() {
            ITag Tag = NBTTagFactory.Create(DefaultName, 128f);
            TestTag(Tag, DefaultName, NBTTagType.Float);
        }


        [TestMethod]
        public void TestCreateString() {
            String Value = "Hello, Is it me your looking for?";
            ITag Tag = NBTTagFactory.Create(DefaultName, Value);
            TestTag(Tag, DefaultName, NBTTagType.String);
        }
    }
}
