namespace AssetTool
{
    [TransferibleStruct("SoftObjectPath")]
    public class FSoftObjectPath : ITransferibleSelector
    {
        public const string StructName = "SoftObjectPath";

        public bool bSerializeInternals;

        public int Value;

        public FString Path;
        public FName AssetPathName;
        public FString SubPathString;
        public FTopLevelAssetPath AssetPath;

        public bool IsNull(Transfer transfer) => AssetPathName?.Value is null || AssetPathName.ComparisonIndex == transfer.GlobalNames.None.ComparisonIndex;

        public FSoftObjectPath() { }

        public FSoftObjectPath(bool bSerializeInternals) { this.bSerializeInternals = bSerializeInternals; }

        public object Move(Transfer transfer, int num, object value)
        {
            var obj = value.ToObject<FSoftObjectPath>(transfer);
            return num == 4 ? obj.Move(transfer) : obj.MoveComplete(transfer);
        }

        public object MoveComplete(Transfer transfer)
        {
            SerializePathWithoutFixup(transfer);
            return this;
        }

        [Location("FArchive& FLinkerLoad::operator<<(FSoftObjectPath& Value)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            if (transfer.GlobalObjects.SoftObjectPathList.Count == 0)
            {
                SerializePathWithoutFixup(transfer);
            }
            else
            {
                transfer.Move(ref Value);
            }
            return this;
        }

        [Location("void FSoftObjectPath::SerializePathWithoutFixup(FArchive& Ar)")]
        private void SerializePathWithoutFixup(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_ADDED_SOFT_OBJECT_PATH)
            {
                transfer.Move(ref Path);
            }
            else if (!transfer.Supports.FSOFTOBJECTPATH_REMOVE_ASSET_PATH_FNAMES)
            {
                transfer.Move(ref AssetPathName);
                transfer.Move(ref SubPathString);
            }
            else
            {
                AssetPath ??= new();
                AssetPath.Move(transfer);
                transfer.Move(ref SubPathString);
            }
        }

        public bool CheckSerializeInternals() => bSerializeInternals;
    }

    [TransferibleStruct("SoftClassPath")]
    public class FSoftClassPath : FSoftObjectPath
    {
    }

    [TransferibleStruct("StringAssetReference")]
    public class FStringAssetReference : FSoftObjectPath
    {
    }

    [TransferibleStruct("StringClassReference")]
    public class FStringClassReference : FSoftObjectPath
    {
    }
}
