namespace AssetTool
{
    [JsonAsset("MultiUserReplicationSettings")]
    public class UMultiUserReplicationSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}