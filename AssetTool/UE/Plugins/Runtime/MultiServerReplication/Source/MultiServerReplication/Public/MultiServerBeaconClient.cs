namespace AssetTool
{
    [JsonAsset("MultiServerBeaconClient")]
    public class AMultiServerBeaconClient : AOnlineBeaconClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}