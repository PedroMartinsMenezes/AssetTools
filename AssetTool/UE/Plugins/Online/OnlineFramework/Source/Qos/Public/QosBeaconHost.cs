namespace AssetTool
{
    [JsonAsset("QosBeaconHost")]
    public class AQosBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}