namespace AssetTool
{
    [JsonAsset("GameViewportSubsystem")]
    public class UGameViewportSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}