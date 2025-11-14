namespace AssetTool
{
    [JsonAsset("VCamOutputProviderBase")]
    public class UVCamOutputProviderBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}