namespace AssetTool
{
    [JsonAsset("AvaMask2DBaseModifier")]
    public class UAvaMask2DBaseModifier : UAvaArrangeBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}