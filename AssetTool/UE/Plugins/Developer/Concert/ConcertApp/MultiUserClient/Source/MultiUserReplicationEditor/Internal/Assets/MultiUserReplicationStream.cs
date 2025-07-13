namespace AssetTool
{
    [JsonAsset("MultiUserReplicationStream")]
    public class UMultiUserReplicationStream : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}