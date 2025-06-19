namespace AssetTool
{
    [JsonAsset("HapticFeedbackEffect_Base")]
    public class UHapticFeedbackEffect_Base : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}