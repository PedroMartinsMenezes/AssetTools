namespace AssetTool
{
    [JsonAsset("SpectatorBeaconClient")]
    public class ASpectatorBeaconClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}