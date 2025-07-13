namespace AssetTool
{
    [JsonAsset("TestBeaconHost")]
    public class ATestBeaconHost : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}