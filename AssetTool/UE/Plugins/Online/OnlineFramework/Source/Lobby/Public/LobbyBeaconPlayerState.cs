namespace AssetTool
{
    [JsonAsset("LobbyBeaconPlayerState")]
    public class ALobbyBeaconPlayerState : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}