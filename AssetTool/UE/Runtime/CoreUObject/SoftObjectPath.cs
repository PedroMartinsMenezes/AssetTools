using System.ComponentModel;

namespace AssetTool
{
    [Location("FArchive& FLinkerLoad::operator<<(FSoftObjectPath& Value)")]
    [Description("void FSoftObjectPath::SerializePath(FArchive& Ar)")]
    public class FSoftObjectPath
    {
        public const string StructName = "SoftObjectPath";

        public bool bSerializeInternals;

        [Check(false)] public int Value;

        #region
        public FTopLevelAssetPath AssetPath;
        public FString SubPathString;
        #endregion

        #region SerializePathWithoutFixup
        [Check("CheckSerializeInternals")]
        public FName AssetPathName;
        #endregion

        public bool IsNull => AssetPath?.PackageName?.Value is null || AssetPath.PackageName.ComparisonIndex == GlobalNames.None.ComparisonIndex;

        public FSoftObjectPath() { }

        public FSoftObjectPath(bool bSerializeInternals) { this.bSerializeInternals = bSerializeInternals; }

        public FSoftObjectPath Move(Transfer transfer)
        {
            if (GlobalObjects.SoftObjectPathList.Count == 0)
            {
                SerializePathWithoutFixup(transfer);
                transfer.Move(ref SubPathString);
            }
            else
            {
                transfer.Move(ref Value);
            }
            return this;
        }

        private void SerializePathWithoutFixup(Transfer transfer)
        {
            transfer.Move(ref AssetPathName);
            AssetPath ??= new();
            AssetPath.PackageName = AssetPathName;
            AssetPath.AssetName = AssetPathName;
        }

        public bool CheckSerializeInternals() => bSerializeInternals;
    }

    public class FSoftClassPath : FSoftObjectPath
    {
    }
}
