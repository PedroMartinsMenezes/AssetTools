namespace AssetTool
{
    [JsonAsset("PCGDataFromActorSettings")]
    public class UPCGDataFromActorSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}