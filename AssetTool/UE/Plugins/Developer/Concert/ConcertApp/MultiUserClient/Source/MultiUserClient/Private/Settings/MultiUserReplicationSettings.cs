namespace AssetTool
{
    [JsonAsset("MultiUserReplicationSettings")]
    public class UMultiUserReplicationSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}