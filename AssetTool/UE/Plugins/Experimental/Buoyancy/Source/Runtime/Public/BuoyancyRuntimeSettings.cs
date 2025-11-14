namespace AssetTool
{
    [JsonAsset("BuoyancyRuntimeSettings")]
    public class UBuoyancyRuntimeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}