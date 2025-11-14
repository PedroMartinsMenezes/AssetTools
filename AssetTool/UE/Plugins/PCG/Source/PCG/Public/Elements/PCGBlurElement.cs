namespace AssetTool
{
    [JsonAsset("PCGBlurSettings")]
    public class UPCGBlurSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}