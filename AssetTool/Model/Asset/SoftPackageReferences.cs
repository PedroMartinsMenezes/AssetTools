namespace AssetTool
{
    public class SoftPackageReferences : Transferible<SoftPackageReferences>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FName> NameList;
        public List<FString> StringList;

        public SoftPackageReferences()
        {
            PackageFileSummary = new() { SoftPackageReferencesOffset = 1, SoftPackageReferencesCount = 1 };
        }

        public SoftPackageReferences(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        [Location("bool FPackageReader::SerializeSoftPackageReferenceList()")]
        public override ITransferible Move(Transfer transfer)
        {
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP) && PackageFileSummary.SoftPackageReferencesOffset > 0 && PackageFileSummary.SoftPackageReferencesCount > 0)
            {
                if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SOFT_OBJECT_PATH))
                {
                    StringList ??= [];
                    StringList.Resize(transfer, PackageFileSummary.SoftPackageReferencesCount);
                    StringList.ForEach(x => transfer.Move(x));
                }
                else
                {
                    NameList ??= [];
                    NameList.Resize(transfer, PackageFileSummary.SoftPackageReferencesCount);
                    NameList.ForEach(x => transfer.Move(x));
                }
            }
            return this;
        }
    }
}
