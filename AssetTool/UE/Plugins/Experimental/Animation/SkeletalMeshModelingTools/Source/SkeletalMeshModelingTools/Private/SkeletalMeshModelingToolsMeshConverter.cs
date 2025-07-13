namespace AssetTool
{
    [JsonAsset("SkeletonFromStaticMeshFactory")]
    public class USkeletonFromStaticMeshFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshFromStaticMeshFactory")]
    public class USkeletalMeshFromStaticMeshFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticMeshToSkeletalMeshConvertOptions")]
    public class UStaticMeshToSkeletalMeshConvertOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}