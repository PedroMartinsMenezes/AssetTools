namespace AssetTool
{
    [JsonAsset("BuoyancyRuntimeSettings")]
    public class UBuoyancyRuntimeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}