namespace AssetTool
{
    [JsonAsset("LevelStreamingLevelInstanceEditor")]
    public class ULevelStreamingLevelInstanceEditor : ULevelStreamingAlwaysLoaded
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}