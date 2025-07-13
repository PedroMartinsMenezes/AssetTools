namespace AssetTool
{
    [JsonAsset("TestBeaconClient")]
    public class ATestBeaconClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}