namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
    public class FObjectImport
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        [Check("CheckPackageName")] public FName PackageName;
        [Check("CheckImportOptional")] public FBool bImportOptional;

        public bool CheckPackageName()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT);
        }
        public bool CheckImportOptional()
        {
            return GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES);
        }
    }
}
