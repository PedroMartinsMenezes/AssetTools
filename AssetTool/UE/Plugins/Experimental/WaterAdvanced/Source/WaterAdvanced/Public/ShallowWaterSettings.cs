namespace AssetTool
{
    [JsonAsset("ShallowWaterSettings")]
    public class UShallowWaterSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}