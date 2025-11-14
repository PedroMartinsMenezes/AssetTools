namespace AssetTool
{
    [JsonAsset("OnlineBeacon")]
    public class AOnlineBeacon : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}