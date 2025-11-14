namespace AssetTool
{
    [JsonAsset("ReplayNetConnection")]
    public class UReplayNetConnection : UNetConnection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}