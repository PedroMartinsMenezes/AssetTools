namespace AssetTool
{
    [JsonAsset("PCGApplyOnActorSettings")]
    public class UPCGApplyOnActorSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}