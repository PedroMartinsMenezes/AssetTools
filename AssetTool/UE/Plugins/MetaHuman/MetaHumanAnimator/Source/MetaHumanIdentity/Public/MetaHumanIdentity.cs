namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityThumbnailInfo")]
    public class UMetaHumanIdentityThumbnailInfo : UThumbnailInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentity")]
    public class UMetaHumanIdentity : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}