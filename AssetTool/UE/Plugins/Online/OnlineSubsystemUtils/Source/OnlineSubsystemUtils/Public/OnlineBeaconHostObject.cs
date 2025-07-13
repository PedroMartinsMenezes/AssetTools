namespace AssetTool
{
    [JsonAsset("OnlineBeaconHostObject")]
    public class AOnlineBeaconHostObject : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}