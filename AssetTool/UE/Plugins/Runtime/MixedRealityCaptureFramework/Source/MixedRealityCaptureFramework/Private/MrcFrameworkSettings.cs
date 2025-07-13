namespace AssetTool
{
    [JsonAsset("MrcFrameworkSettings")]
    public class UMrcFrameworkSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}