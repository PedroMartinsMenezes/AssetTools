namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityPromotedFrame")]
    public class UMetaHumanIdentityPromotedFrame : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityCameraFrame")]
    public class UMetaHumanIdentityCameraFrame : UMetaHumanIdentityPromotedFrame
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityFootageFrame")]
    public class UMetaHumanIdentityFootageFrame : UMetaHumanIdentityPromotedFrame
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}