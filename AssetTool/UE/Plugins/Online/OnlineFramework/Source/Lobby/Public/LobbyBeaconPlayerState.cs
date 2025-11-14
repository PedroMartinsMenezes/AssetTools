namespace AssetTool
{
    [JsonAsset("LobbyBeaconPlayerState")]
    public class ALobbyBeaconPlayerState : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}