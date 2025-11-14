namespace AssetTool
{
    [JsonAsset("MultiServerBeaconClient")]
    public class AMultiServerBeaconClient : AOnlineBeaconClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}