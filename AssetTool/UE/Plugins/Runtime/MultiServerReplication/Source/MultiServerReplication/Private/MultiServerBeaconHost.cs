namespace AssetTool
{
    [JsonAsset("MultiServerBeaconHost")]
    public class AMultiServerBeaconHost : AOnlineBeaconHost
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}