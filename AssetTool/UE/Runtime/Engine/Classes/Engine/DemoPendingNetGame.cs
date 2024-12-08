namespace AssetTool
{
    [JsonAsset("DemoPendingNetGame")]
    public class UDemoPendingNetGame : UPendingNetGame
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}