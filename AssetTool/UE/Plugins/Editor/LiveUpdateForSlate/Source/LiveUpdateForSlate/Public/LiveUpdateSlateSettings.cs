namespace AssetTool
{
    [JsonAsset("LiveUpdateSlateSettings")]
    public class ULiveUpdateSlateSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}