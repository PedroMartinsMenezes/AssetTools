namespace AssetTool
{
    [JsonAsset("CEEffectorSubsystem")]
    public class UCEEffectorSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}