namespace AssetTool
{
    [JsonAsset("TakeRecorderSubsystem")]
    public class UTakeRecorderSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}