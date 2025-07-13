namespace AssetTool
{
    [JsonAsset("MultiUserReplicationStreamAsset")]
    public class UMultiUserReplicationStreamAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}