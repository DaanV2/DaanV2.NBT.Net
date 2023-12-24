# DaanV2-NBT.Net

[![.NET Unit test](https://github.com/DaanV2/DaanV2.NBT.Net/actions/workflows/dotnet-test.yml/badge.svg)](https://github.com/DaanV2/DaanV2.NBT.Net/actions/workflows/dotnet-test.yml)
[![📦 Nuget Release](https://github.com/DaanV2/DaanV2.NBT.Net/actions/workflows/publish.yml/badge.svg)](https://github.com/DaanV2/DaanV2.NBT.Net/actions/workflows/publish.yml)  
![Nuget Version](https://img.shields.io/nuget/v/DaanV2.NBT.Net)
![Nuget Downloads](https://img.shields.io/nuget/dt/DaanV2.NBT.Net)

An NBT library for reading and writing NBT files/data [Nuget package](https://www.nuget.org/packages/DaanV2.NBT.Net/)

# Usage

## Read a file

```cs
var Compound = NBTReader.ReadFile("Path to file", Endian.Little, NBTCompression.Auto);
var age = Compound.GetSubTag("Age");

//Retrieve value if you know what type it should be
Int32 item = SubTag.GetValue<Int32>();

//OR
if (SubTag is NBTTagInt a) {
    Assert.IsTrue(a.Value == 256, "Hello set wrong")
}

//OR
var item = Compound.GetSubTag<Int32>("Age");
```

## Writes to a file

```cs
ITag Tag;

//Writes the tag to the specified file using GZIP compression and little-endian methods
NBTWriter.WriteFile("Path to file", Tag, NBTCompression.Gzip, Endian.Little);

//Writes the tag to the specified file using no compression and little-endian methods
NBTWriter.WriteFile("Path to file", Tag, Endian.Little);
```

## Building a structure

```cs
CompoundBuilder Builder = new CompoundBuilder("Root", 10);
Builder.Add("IsDetermined", true);
Builder.Add("Amount", 5);

ITag = Builder.GetResult();
```

# Installation

Check that the NuGet packages have been downloaded.

# Dependencies:

## Solved with NuGet

- [Zlib](https://github.com/cinderblocks/zlib.net)
- [DaanV2.Essentials.Net](https://github.com/DaanV2/DaanV2.Essentials.Net)
