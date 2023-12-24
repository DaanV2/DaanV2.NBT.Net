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

        Assert.IsTrue(Out.GetChildValue<Int32>("Hello") == 256, "Hello set wrong");

        ITag child = Out.GetChild("Me.Hello");

        Assert.IsTrue(child.Type == NBTTagType.List, "List is wrong type");
        Assert.IsTrue((NBTTagType)child.GetInformation(NBTTagInformation.ListSubtype) == NBTTagType.String, "Wrong sub type");
        Assert.IsTrue(child.Count == 2, "Wrong amount of items");
        Assert.IsTrue(child.GetChildValue<String>(0) == "me.Name");
        Assert.IsTrue(child.GetChildValue<String>(1) == "me.Temp");
    }
}
