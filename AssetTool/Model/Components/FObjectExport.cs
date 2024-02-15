namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectExport& E)")]
    public class FObjectExport
    {
        public FPackageIndex ClassIndex;
        public FPackageIndex SuperIndex;
        [Check("CheckTemplateIndex")] public FPackageIndex TemplateIndex;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        public UInt32 ObjectFlags;
        [Check("CheckSerial")] public Int64 SerialSize;
        [Check("CheckSerial")] public Int64 SerialOffset;
        public FBool bForcedExport;
        public FBool bNotForClient;
        public FBool bNotForServer;
        [Check("CheckInheritedInstance")] public FBool bIsInheritedInstance;
        public UInt32 PackageFlags;
        [Check("CheckAlwaysLoadedForEditorGame")] public FBool bNotAlwaysLoadedForEditorGame;
        [Check("CheckIsAsset")] public FBool bIsAsset;
        [Check("CheckGeneratePublicHash")] public FBool bGeneratePublicHash;
        [Check("CheckDeps")] public Int32 FirstExportDependency;
        [Check("CheckDeps")] public Int32 SerializationBeforeSerializationDependencies;
        [Check("CheckDeps")] public Int32 CreateBeforeSerializationDependencies;
        [Check("CheckDeps")] public Int32 SerializationBeforeCreateDependencies;
        [Check("CheckDeps")] public Int32 CreateBeforeCreateDependencies;

        public bool CheckTemplateIndex()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS);
        }
        public bool CheckSerial()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES);
        }
        public bool CheckInheritedInstance()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.TRACK_OBJECT_EXPORT_IS_INHERITED);
        }
        public bool CheckAlwaysLoadedForEditorGame()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_LOAD_FOR_EDITOR_GAME);
        }
        public bool CheckIsAsset()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT);
        }
        public bool CheckGeneratePublicHash()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES);
        }
        public bool CheckDeps()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS);
        }
    }
}
