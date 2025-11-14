namespace AssetTool
{
    [JsonAsset("PCGApplyOnActorSettings")]
    public class UPCGApplyOnActorSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}