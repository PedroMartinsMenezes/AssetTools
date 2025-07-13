namespace AssetTool
{
    [JsonAsset("MultiUserReplicationSubsystem")]
    public class UMultiUserReplicationSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}