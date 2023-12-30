using AssetTool.Model;

namespace AssetTool.Service
{
    public static class PackageDataMainExt
    {
        public static void Write(this BinaryWriter writer, XPackageDataMain item)
        {
            writer.Write(item.DeserializePackageData.DependencyDataOffset);
            writer.Write(item.DeserializePackageData.ObjectCount);
            writer.Write(item.ObjectPackageData.ObjectPath);
            writer.Write(item.ObjectPackageData.ObjectClassName);
            writer.Write(item.ObjectPackageData.TagCount);
            writer.Write(item.TagData.Key);
            writer.Write(item.TagData.Value);
        }

        public static XPackageDataMain Read(this BinaryReader reader, XPackageDataMain item)
        {
            reader.Read(ref item.DeserializePackageData.DependencyDataOffset);
            reader.Read(ref item.DeserializePackageData.ObjectCount);
            reader.Read(ref item.ObjectPackageData.ObjectPath);
            reader.Read(ref item.ObjectPackageData.ObjectClassName);
            reader.Read(ref item.ObjectPackageData.TagCount);
            reader.Read(ref item.TagData.Key);
            reader.Read(ref item.TagData.Value);
            return item;
        }
    }
}
