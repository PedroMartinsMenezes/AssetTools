namespace AssetTool
{
    [JsonAsset("LobbyBeaconHost")]
    public class ALobbyBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}