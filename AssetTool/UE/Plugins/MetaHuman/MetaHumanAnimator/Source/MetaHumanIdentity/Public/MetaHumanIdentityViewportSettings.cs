namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityViewportSettings")]
    public class UMetaHumanIdentityViewportSettings : UMetaHumanViewportSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}