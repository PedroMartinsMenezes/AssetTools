namespace AssetTool
{
    [JsonAsset("PCGBlurSettings")]
    public class UPCGBlurSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}