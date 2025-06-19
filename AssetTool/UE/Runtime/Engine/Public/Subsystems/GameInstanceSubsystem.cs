namespace AssetTool
{
    [JsonAsset("GameInstanceSubsystem")]
    public class UGameInstanceSubsystem : USubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}