namespace AssetTool
{
    [JsonAsset("CEEffectorSubsystem")]
    public class UCEEffectorSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}