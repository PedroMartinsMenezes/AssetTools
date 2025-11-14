namespace AssetTool
{
    [JsonAsset("QosBeaconHost")]
    public class AQosBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}