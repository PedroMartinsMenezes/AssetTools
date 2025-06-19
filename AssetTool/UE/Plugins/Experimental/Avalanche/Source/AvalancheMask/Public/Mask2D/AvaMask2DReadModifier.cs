namespace AssetTool
{
    [JsonAsset("AvaMask2DReadModifier")]
    public class UAvaMask2DReadModifier : UAvaMask2DBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}