namespace AssetTool
{
    [JsonAsset("SpectatorBeaconState")]
    public class USpectatorBeaconState : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}