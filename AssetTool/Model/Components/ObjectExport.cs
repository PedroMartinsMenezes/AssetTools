using AssetTool.Model.Basic;

namespace AssetTool.Model
{
    //[3] 2320 .. 2608
    public class FObjectExport
    {
        public FPackageIndex ClassIndex = new();
        public FPackageIndex SuperIndex = new();
        public FPackageIndex TemplateIndex = new();
        public FPackageIndex OuterIndex = new();
        public FName ObjectName = new();
        public Int64 SerialSize;
        public Int64 SerialOffset;
        public bool bForcedExport;
        public bool bNotForClient;
        public bool bNotForServer;
        public bool bIsInheritedInstance;
        public UInt32 PackageFlags;
        public bool bNotAlwaysLoadedForEditorGame;
        public bool bIsAsset;
        public bool bGeneratePublicHash;
        public Int32 FirstExportDependency;
        public Int32 SerializationBeforeSerializationDependencies;
        public Int32 CreateBeforeSerializationDependencies;
        public Int32 SerializationBeforeCreateDependencies;
        public Int32 CreateBeforeCreateDependencies;
    }
}
