namespace AssetTool
{
    [JsonAsset("PCGDataFromActorSettings")]
    public class UPCGDataFromActorSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}