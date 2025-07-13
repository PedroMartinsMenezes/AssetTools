namespace AssetTool
{
    [JsonAsset("MultiServerBeaconHost")]
    public class AMultiServerBeaconHost : AOnlineBeaconHost
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}