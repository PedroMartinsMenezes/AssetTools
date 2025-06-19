namespace AssetTool
{
    [JsonAsset("PCGAttractSettings")]
    public class UPCGAttractSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}