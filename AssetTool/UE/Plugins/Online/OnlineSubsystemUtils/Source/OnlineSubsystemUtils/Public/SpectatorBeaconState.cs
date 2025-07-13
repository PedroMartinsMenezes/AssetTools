namespace AssetTool
{
    [JsonAsset("SpectatorBeaconState")]
    public class USpectatorBeaconState : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}