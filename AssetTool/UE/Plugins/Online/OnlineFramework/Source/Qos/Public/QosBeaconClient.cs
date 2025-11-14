namespace AssetTool
{
    [JsonAsset("QosBeaconClient")]
    public class AQosBeaconClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}