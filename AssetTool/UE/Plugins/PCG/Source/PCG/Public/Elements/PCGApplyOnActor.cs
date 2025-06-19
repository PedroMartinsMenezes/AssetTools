namespace AssetTool
{
    [JsonAsset("PCGApplyOnActorSettings")]
    public class UPCGApplyOnActorSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}