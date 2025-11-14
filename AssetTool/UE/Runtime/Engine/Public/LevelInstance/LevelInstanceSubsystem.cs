namespace AssetTool
{
    [JsonAsset("LevelInstanceSubsystem")]
    public class ULevelInstanceSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}