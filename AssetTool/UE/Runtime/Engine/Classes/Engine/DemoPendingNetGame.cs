namespace AssetTool
{
    [JsonAsset("DemoPendingNetGame")]
    public class UDemoPendingNetGame : UPendingNetGame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}