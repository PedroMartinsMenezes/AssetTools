namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityThumbnailInfo")]
    public class UMetaHumanIdentityThumbnailInfo : UThumbnailInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentity")]
    public class UMetaHumanIdentity : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}