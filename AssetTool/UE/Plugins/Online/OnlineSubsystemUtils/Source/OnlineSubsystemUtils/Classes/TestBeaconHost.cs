namespace AssetTool
{
    [JsonAsset("TestBeaconHost")]
    public class ATestBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}