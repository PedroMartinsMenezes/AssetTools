namespace AssetTool
{
    [JsonAsset("MultiUserSubsystem")]
    public class UMultiUserSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}