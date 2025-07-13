namespace AssetTool
{
    [JsonAsset("QosBeaconClient")]
    public class AQosBeaconClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}