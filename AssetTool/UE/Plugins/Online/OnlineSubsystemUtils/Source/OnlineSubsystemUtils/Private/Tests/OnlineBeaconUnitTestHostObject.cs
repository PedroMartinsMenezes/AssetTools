namespace AssetTool
{
    [JsonAsset("OnlineBeaconUnitTestHostObject")]
    public class AOnlineBeaconUnitTestHostObject : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}