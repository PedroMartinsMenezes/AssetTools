namespace AssetTool
{
    [JsonAsset("SpectatorBeaconHost")]
    public class ASpectatorBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}