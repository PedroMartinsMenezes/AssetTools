namespace AssetTool
{
    [JsonAsset("MultiUserReplicationSubsystem")]
    public class UMultiUserReplicationSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}