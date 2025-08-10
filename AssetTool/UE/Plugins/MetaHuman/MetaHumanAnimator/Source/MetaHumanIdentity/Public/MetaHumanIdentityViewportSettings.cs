namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityViewportSettings")]
    public class UMetaHumanIdentityViewportSettings : UMetaHumanViewportSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}