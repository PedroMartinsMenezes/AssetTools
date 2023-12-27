using AssetTool.Model;

namespace AssetTool.Service
{
    public static class ObjectExportExt
    {
        public static void Write(this BinaryWriter writer, List<FObjectExport> list)
        {
            list.ForEach(item => writer.Write(item));
        }

        public static void Write(this BinaryWriter writer, FObjectExport item)
        {
            writer.Write(item.ClassIndex.Index);
            writer.Write(item.SuperIndex.Index);
            writer.Write(item.TemplateIndex.Index);
            writer.Write(item.OuterIndex.Index);
            writer.Write(item.ObjectName);
            writer.Write(item.SerialSize);
            writer.Write(item.SerialOffset);
            writer.Write(item.bForcedExport ? 1 : 0);
            writer.Write(item.bNotForClient ? 1 : 0);
            writer.Write(item.bNotForServer ? 1 : 0);
            writer.Write(item.bIsInheritedInstance ? 1 : 0);
            writer.Write(item.PackageFlags);
            writer.Write(item.bNotAlwaysLoadedForEditorGame ? 1 : 0);
            writer.Write(item.bIsAsset ? 1 : 0);
            writer.Write(item.bGeneratePublicHash ? 1 : 0);
            writer.Write(item.FirstExportDependency);
            writer.Write(item.SerializationBeforeSerializationDependencies);
            writer.Write(item.CreateBeforeSerializationDependencies);
            writer.Write(item.SerializationBeforeCreateDependencies);
            writer.Write(item.CreateBeforeCreateDependencies);
        }
    }
}
