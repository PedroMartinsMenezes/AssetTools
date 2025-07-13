namespace AssetTool
{
    [JsonAsset("SlateSettings")]
    public class USlateSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}