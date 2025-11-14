namespace AssetTool
{
    [JsonAsset("SkeletonFromStaticMeshFactory")]
    public class USkeletonFromStaticMeshFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshFromStaticMeshFactory")]
    public class USkeletalMeshFromStaticMeshFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticMeshToSkeletalMeshConvertOptions")]
    public class UStaticMeshToSkeletalMeshConvertOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}