namespace AssetTool
{
    [JsonAsset("MetaHumanViewportSettings")]
    public class UMetaHumanViewportSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}