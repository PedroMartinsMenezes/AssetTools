namespace AssetTool
{
    [JsonAsset("ReplayNetConnection")]
    public class UReplayNetConnection : UNetConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}