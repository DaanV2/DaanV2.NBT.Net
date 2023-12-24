using System;
using System.Collections.Generic;
using DaanV2.NBT.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaanV2.NBT.Test.Builders;
[TestClass]
public partial class CompoundBuilderTest {
    [TestMethod]
    public void TestBuild() {
        var Builder = new CompoundBuilder("Root", 100);
        Builder.Add("Hello", 1);
        Builder.Add("Hello", 256);
        Builder.Add("Me.Hello", new List<String>() { "me.Name", "me.Temp" });

        NBTTagCompound Out = Builder.GetResult();

        Assert.IsTrue(Out.GetSubValue<Int32>("Hello") == 256, "Hello set wrong");

        ITag SubTag = Out.GetSubTag("Hello");

        Assert.IsTrue(SubTag.Type == NBTTagType.List, "List is wrong type");
        Assert.IsTrue((NBTTagType)SubTag.GetInformation(NBTTagInformation.ListSubtype) == NBTTagType.String, "Wrong sub type");
        Assert.IsTrue(SubTag.Count == 2, "Wrong amount of items");
        Assert.IsTrue(SubTag.GetSubValue<String>(0) == "me.Name");
        Assert.IsTrue(SubTag.GetSubValue<String>(1) == "me.Temp");
    }
}
