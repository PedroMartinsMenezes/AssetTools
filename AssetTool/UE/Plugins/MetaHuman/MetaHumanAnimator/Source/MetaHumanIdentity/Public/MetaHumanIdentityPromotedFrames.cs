namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityPromotedFrame")]
    public class UMetaHumanIdentityPromotedFrame : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityCameraFrame")]
    public class UMetaHumanIdentityCameraFrame : UMetaHumanIdentityPromotedFrame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityFootageFrame")]
    public class UMetaHumanIdentityFootageFrame : UMetaHumanIdentityPromotedFrame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}