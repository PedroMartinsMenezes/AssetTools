namespace AssetTool
{
    public class SoftPackageReferences : Transferible<SoftPackageReferences>
    {
        public List<FName> NameList;
        public List<FString> StringList;
        public Int32 SoftPackageReferencesOffset;
        public Int32 SoftPackageReferencesCount;

        public SoftPackageReferences() { }

        public SoftPackageReferences(FPackageFileSummary PackageFileSummary)
        {
            SoftPackageReferencesOffset = PackageFileSummary.SoftPackageReferencesOffset;
            SoftPackageReferencesCount = PackageFileSummary.SoftPackageReferencesCount;
        }

        [Location("bool FPackageReader::SerializeSoftPackageReferenceList()")]
        public override ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP && SoftPackageReferencesOffset > 0 && SoftPackageReferencesCount > 0)
            {
                if (!transfer.Supports.VER_UE4_ADDED_SOFT_OBJECT_PATH)
                {
                    transfer.Move(ref StringList, SoftPackageReferencesCount);
                }
                else
                {
                    transfer.Move(ref NameList, SoftPackageReferencesCount);
                }
            }
            return this;
        }
    }
}
