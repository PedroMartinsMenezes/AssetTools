namespace AssetTool
{
    [JsonAsset("LevelInstanceSubsystem")]
    public class ULevelInstanceSubsystem : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}