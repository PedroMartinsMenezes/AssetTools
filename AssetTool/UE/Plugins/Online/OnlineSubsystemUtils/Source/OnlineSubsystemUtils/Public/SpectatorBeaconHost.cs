namespace AssetTool
{
    [JsonAsset("SpectatorBeaconHost")]
    public class ASpectatorBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}