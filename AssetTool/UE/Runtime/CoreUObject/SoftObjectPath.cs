using System.Text.Json.Serialization;

namespace AssetTool
{
    public static class FSoftObjectPathSelector
    {
        public const string StructName = "SoftObjectPath";

        public static object Move(Transfer transfer, int num, object value)
        {
            return num == 4 ? value.ToObject<FSoftObjectPath>().Move(transfer) : value.ToObject<FSoftObjectPath>().MoveComplete(transfer);
        }
        //public static object GetDerived(FPropertyTag tag)
        //{
        //    return tag.Size == FVector2f.SIZE ? new FVector2fJson(tag) : new FVector2dJson(tag);
        //}
    }

    [Location("void FSoftObjectPath::SerializePath(FArchive& Ar)")]
    public class FSoftObjectPath
    {
        public const string StructName = "SoftObjectPath";

        public bool bSerializeInternals;

        [Check(false)] public int Value;

        public FString Path;
        public FName AssetPathName;
        public FString SubPathString;
        public FTopLevelAssetPath AssetPath;

        [JsonIgnore]
        public bool IsNull => AssetPathName?.Value is null || AssetPathName.ComparisonIndex == GlobalNames.None.ComparisonIndex;

        public FSoftObjectPath() { }

        public FSoftObjectPath(bool bSerializeInternals) { this.bSerializeInternals = bSerializeInternals; }

        public FSoftObjectPath MoveComplete(Transfer transfer)
        {
            SerializePathWithoutFixup(transfer);
            return this;
        }

        public virtual FSoftObjectPath Move(Transfer transfer)
        {
            if (GlobalObjects.SoftObjectPathList.Count == 0)
            {
                SerializePathWithoutFixup(transfer);
            }
            else
            {
                transfer.Move(ref Value);
            }
            return this;
        }

        private void SerializePathWithoutFixup(Transfer transfer)
        {
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SOFT_OBJECT_PATH))
            {
                transfer.Move(ref Path);
            }
            else if (!Supports.UEVer(EUnrealEngineObjectUE5Version.FSOFTOBJECTPATH_REMOVE_ASSET_PATH_FNAMES))
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

    [Location("struct FSoftClassPath : public FSoftObjectPath")]
    public class FSoftClassPath : FSoftObjectPath
    {
        public new const string StructName = "SoftClassPath";
    }

    [Location("typedef FSoftObjectPath FStringAssetReference")]
    public class FStringAssetReference : FSoftObjectPath
    {
        public new const string StructName = "StringAssetReference";
    }

    [Location("typedef FSoftClassPath FStringClassReference")]
    public class FStringClassReference : FSoftObjectPath
    {
        public new const string StructName = "StringClassReference";
    }
}
