namespace AssetTool
{
    [JsonAsset("DemoPendingNetGame")]
    public class UDemoPendingNetGame : UPendingNetGame
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}