namespace AssetTool
{
    //[3] 2320 .. 2608
    public class FObjectExport
    {
        public FPackageIndex ClassIndex = new();
        public FPackageIndex SuperIndex = new();
        public FPackageIndex TemplateIndex = new();
        public FPackageIndex OuterIndex = new();
        public FName ObjectName = new();
        public UInt32 ObjectFlags;
        public Int64 SerialSize;
        public Int64 SerialOffset;
        public FBool bForcedExport = new();
        public FBool bNotForClient = new();
        public FBool bNotForServer = new();
        public FBool bIsInheritedInstance = new();
        public UInt32 PackageFlags;
        public FBool bNotAlwaysLoadedForEditorGame = new();
        public FBool bIsAsset = new();
        public FBool bGeneratePublicHash = new();
        public Int32 FirstExportDependency;
        public Int32 SerializationBeforeSerializationDependencies;
        public Int32 CreateBeforeSerializationDependencies;
        public Int32 SerializationBeforeCreateDependencies;
        public Int32 CreateBeforeCreateDependencies;
    }

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
            writer.Write(item.ObjectFlags);
            writer.Write(item.SerialSize);
            writer.Write(item.SerialOffset);
            writer.Write(item.bForcedExport);
            writer.Write(item.bNotForClient);
            writer.Write(item.bNotForServer);
            writer.Write(item.bIsInheritedInstance);
            writer.Write(item.PackageFlags);
            writer.Write(item.bNotAlwaysLoadedForEditorGame);
            writer.Write(item.bIsAsset);
            writer.Write(item.bGeneratePublicHash);
            writer.Write(item.FirstExportDependency);
            writer.Write(item.SerializationBeforeSerializationDependencies);
            writer.Write(item.CreateBeforeSerializationDependencies);
            writer.Write(item.SerializationBeforeCreateDependencies);
            writer.Write(item.CreateBeforeCreateDependencies);
        }

        public static FObjectExport Read(this BinaryReader reader, FObjectExport item)
        {
            reader.ReadPackageIndex(item.ClassIndex);
            reader.ReadPackageIndex(item.SuperIndex);
            reader.ReadPackageIndex(item.TemplateIndex);
            reader.ReadPackageIndex(item.OuterIndex);
            reader.Read(item.ObjectName);
            reader.Read(ref item.ObjectFlags);
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

        public static List<FObjectExport> ReadExportMap(this BinaryReader reader, int offset, int count)
        {
            reader.BaseStream.Position = offset;
            return Enumerable.Range(0, count).Select(x => reader.Read(new FObjectExport())).ToList();
        }
    }
}
