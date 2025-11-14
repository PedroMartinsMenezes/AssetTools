namespace AssetTool
{
    [JsonAsset("LobbyBeaconClient")]
    public class ALobbyBeaconClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}