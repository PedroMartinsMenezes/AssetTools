namespace AssetTool
{
    [JsonAsset("SpectatorBeaconClient")]
    public class ASpectatorBeaconClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}