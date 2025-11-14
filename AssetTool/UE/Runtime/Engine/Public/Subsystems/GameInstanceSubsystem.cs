namespace AssetTool
{
    [JsonAsset("GameInstanceSubsystem")]
    public class UGameInstanceSubsystem : USubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}