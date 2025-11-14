namespace AssetTool
{
    [JsonAsset("PCGNormalToDensitySettings")]
    public class UPCGNormalToDensitySettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}