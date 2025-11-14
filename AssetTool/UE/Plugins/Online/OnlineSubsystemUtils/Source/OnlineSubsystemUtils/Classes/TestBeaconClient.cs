namespace AssetTool
{
    [JsonAsset("TestBeaconClient")]
    public class ATestBeaconClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}