# DaanV2-NBT.Net

<p align="center">
  <a href="https://www.nuget.org/packages/DaanV2.UUID.Net/">
    <img alt="Nuget" src="https://img.shields.io/nuget/v/DaanV2.UUID.Net?style=for-the-badge">
    <img alt="Nuget" src="https://img.shields.io/nuget/dt/DaanV2.UUID.Net?style=for-the-badge">
  </a>
</p>

An NBT library for reading and writing NBT files/data
[Nuget package](https://www.nuget.org/packages/DaanV2.UUID.Net/)

# Usage

## Read the file into a nbt structure
```cs
    Itag Compound = NBTReader.ReadFile("Path to file", Endianness.LittleEndian, NBTCompression.Auto);
```

## Writes to a file
```cs
    ITag Tag;

    //Writes the tag to the specified file using GZIP compression and little-endian methods
    NBTWriter.WriteFile("Path to file", Tag, NBTCompression.Gzip, Endianness.LittleEndian);

    //Writes the tag to the specified file using no compression and little-endian methods
    NBTWriter.WriteFile("Path to file", Tag, Endianness.LittleEndian);
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
