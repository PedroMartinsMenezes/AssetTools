namespace AssetTool
{
    public class SoftPackageReferences : ITransferible
    {
        public List<FName> NameList;
        public List<FString> StringList;
        public Int32 SoftPackageReferencesCount;

        public SoftPackageReferences() { }

        public SoftPackageReferences(int softPackageReferencesCount)
        {
            SoftPackageReferencesCount = softPackageReferencesCount;
        }

        [Location("bool FPackageReader::SerializeSoftPackageReferenceList()")]
        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP && SoftPackageReferencesCount > 0)
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
