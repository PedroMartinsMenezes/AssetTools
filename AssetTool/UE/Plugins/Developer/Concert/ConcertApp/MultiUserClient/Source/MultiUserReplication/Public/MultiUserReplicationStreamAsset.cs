namespace AssetTool
{
    [JsonAsset("MultiUserReplicationStreamAsset")]
    public class UMultiUserReplicationStreamAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}