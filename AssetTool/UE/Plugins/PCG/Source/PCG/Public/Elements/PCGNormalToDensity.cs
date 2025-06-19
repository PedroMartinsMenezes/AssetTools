namespace AssetTool
{
    [JsonAsset("PCGNormalToDensitySettings")]
    public class UPCGNormalToDensitySettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}