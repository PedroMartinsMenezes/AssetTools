namespace AssetTool
{
    [JsonAsset("CommonUISettings")]
    public class UCommonUISettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}