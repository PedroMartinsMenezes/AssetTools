namespace AssetTool
{
    [JsonAsset("MetaHumanViewportSettings")]
    public class UMetaHumanViewportSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}