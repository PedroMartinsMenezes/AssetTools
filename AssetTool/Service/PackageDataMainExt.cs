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
    }
}
