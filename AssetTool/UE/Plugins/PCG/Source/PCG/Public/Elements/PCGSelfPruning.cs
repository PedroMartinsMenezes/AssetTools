namespace AssetTool
{
    [JsonAsset("PCGSelfPruningSettings")]
    public class UPCGSelfPruningSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}