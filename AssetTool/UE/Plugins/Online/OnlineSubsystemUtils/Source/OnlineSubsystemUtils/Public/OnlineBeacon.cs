namespace AssetTool
{
    [JsonAsset("OnlineBeacon")]
    public class AOnlineBeacon : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}