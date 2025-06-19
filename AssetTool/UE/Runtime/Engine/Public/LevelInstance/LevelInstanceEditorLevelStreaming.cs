namespace AssetTool
{
    [JsonAsset("LevelStreamingLevelInstanceEditor")]
    public class ULevelStreamingLevelInstanceEditor : ULevelStreamingAlwaysLoaded
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}