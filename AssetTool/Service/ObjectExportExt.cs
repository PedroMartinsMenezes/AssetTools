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

        public static FObjectExport Read(this BinaryReader reader, FObjectExport item)
        {
            reader.Read(ref item.ClassIndex);
            reader.Read(ref item.SuperIndex);
            reader.Read(ref item.TemplateIndex);
            reader.Read(ref item.OuterIndex);
            reader.Read(ref item.ObjectName);
            reader.Read(ref item.SerialSize);
            reader.Read(ref item.SerialOffset);
            reader.Read(ref item.bForcedExport);
            reader.Read(ref item.bNotForClient);
            reader.Read(ref item.bNotForServer);
            reader.Read(ref item.bIsInheritedInstance);
            reader.Read(ref item.PackageFlags);
            reader.Read(ref item.bNotAlwaysLoadedForEditorGame);
            reader.Read(ref item.bIsAsset);
            reader.Read(ref item.bGeneratePublicHash);
            reader.Read(ref item.FirstExportDependency);
            reader.Read(ref item.SerializationBeforeSerializationDependencies);
            reader.Read(ref item.CreateBeforeSerializationDependencies);
            reader.Read(ref item.SerializationBeforeCreateDependencies);
            reader.Read(ref item.CreateBeforeCreateDependencies);
            return item;
        }

        public static List<FObjectExport> ReadList(this BinaryReader reader, int count, FObjectExport item)
        {
            return Enumerable.Range(0, count).Select(x => reader.Read(new FObjectExport())).ToList();
        }
    }
}
