namespace AssetTool
{
    [JsonAsset("MultiServerBeaconHostObject")]
    public class AMultiServerBeaconHostObject : AOnlineBeaconHostObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}