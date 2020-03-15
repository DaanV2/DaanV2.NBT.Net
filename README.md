# DaanV2-NBT.Net
A NBT library for reading and writing nbt files/data

# Usage

## Read the file into a nbt structure
```cs
    Itag Compound = NBTReader.ReadFile("Path to file", Endianness.LittleEndian, NBTCompression.Auto);
```

## Writes the nbt tag into a file
```cs
    ITag Tag;

    //Writes the tag to the specified file using GZIP compression and little endian methods
    NBTWriter.WriteFile("Path to file", Tag, NBTCompression.Gzip, Endianness.LittleEndian);

    //Writes the tag to the specified file using no compression and little endian methods
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
Check that the nuget packages have been downloaded.

# Dependencies:

## Solved with NuGet
- [Zlib](https://github.com/cinderblocks/zlib.net)
- [DaanV2.Essentials.Net](https://github.com/DaanV2/DaanV2.Essentials.Net)