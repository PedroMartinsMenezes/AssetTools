namespace AssetTool
{
    [JsonAsset("LobbyBeaconHost")]
    public class ALobbyBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}