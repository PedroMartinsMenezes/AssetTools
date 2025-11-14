namespace AssetTool
{
    [JsonAsset("MultiUserReplicationStream")]
    public class UMultiUserReplicationStream : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}