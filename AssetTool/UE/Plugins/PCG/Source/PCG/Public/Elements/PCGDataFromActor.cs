namespace AssetTool
{
    [JsonAsset("PCGDataFromActorSettings")]
    public class UPCGDataFromActorSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}