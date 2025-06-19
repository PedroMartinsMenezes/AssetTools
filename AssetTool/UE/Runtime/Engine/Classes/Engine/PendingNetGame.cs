namespace AssetTool
{
    [JsonAsset("PendingNetGame")]
    public class UPendingNetGame : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}