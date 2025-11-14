namespace AssetTool
{
    [JsonAsset("PendingNetGame")]
    public class UPendingNetGame : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}