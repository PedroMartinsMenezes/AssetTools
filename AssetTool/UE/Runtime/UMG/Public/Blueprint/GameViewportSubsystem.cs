namespace AssetTool
{
    [JsonAsset("GameViewportSubsystem")]
    public class UGameViewportSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}