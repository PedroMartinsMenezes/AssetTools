namespace AssetTool
{
    [JsonAsset("OnlineBeaconHostObject")]
    public class AOnlineBeaconHostObject : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}