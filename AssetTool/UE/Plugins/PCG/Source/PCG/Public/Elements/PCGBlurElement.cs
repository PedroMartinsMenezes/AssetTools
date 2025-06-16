namespace AssetTool
{
    [JsonAsset("PCGBlurSettings")]
    public class UPCGBlurSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}