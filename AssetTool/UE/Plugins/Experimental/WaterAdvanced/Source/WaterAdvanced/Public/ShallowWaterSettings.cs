namespace AssetTool
{
    [JsonAsset("ShallowWaterSettings")]
    public class UShallowWaterSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}