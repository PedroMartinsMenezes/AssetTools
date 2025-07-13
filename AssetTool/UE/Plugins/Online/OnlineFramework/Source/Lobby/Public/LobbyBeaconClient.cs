namespace AssetTool
{
    [JsonAsset("LobbyBeaconClient")]
    public class ALobbyBeaconClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}