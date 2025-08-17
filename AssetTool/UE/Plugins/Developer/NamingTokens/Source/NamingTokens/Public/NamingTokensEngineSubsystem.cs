namespace AssetTool
{
    [JsonAsset("NamingTokensEngineSubsystem")]
    public class UNamingTokensEngineSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}