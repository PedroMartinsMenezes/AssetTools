namespace AssetTool
{
    [JsonAsset("OnlineBeaconUnitTestHostObject")]
    public class AOnlineBeaconUnitTestHostObject : AOnlineBeaconHostObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}