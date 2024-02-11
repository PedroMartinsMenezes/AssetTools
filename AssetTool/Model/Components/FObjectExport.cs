namespace AssetTool
{
    //[3] 2320 .. 2608
    public class FObjectExport
    {
        public FPackageIndex ClassIndex;
        public FPackageIndex SuperIndex;
        public FPackageIndex TemplateIndex;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        public UInt32 ObjectFlags;
        public Int64 SerialSize;
        public Int64 SerialOffset;
        public FBool bForcedExport;
        public FBool bNotForClient;
        public FBool bNotForServer;
        public FBool bIsInheritedInstance;
        public UInt32 PackageFlags;
        public FBool bNotAlwaysLoadedForEditorGame;
        public FBool bIsAsset;
        public FBool bGeneratePublicHash;
        public Int32 FirstExportDependency;
        public Int32 SerializationBeforeSerializationDependencies;
        public Int32 CreateBeforeSerializationDependencies;
        public Int32 SerializationBeforeCreateDependencies;
        public Int32 CreateBeforeCreateDependencies;
    }
}
