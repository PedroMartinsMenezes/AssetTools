namespace AssetTool
{
    [JsonAsset("LevelStreamingPersistent")]
    public class ULevelStreamingPersistent : ULevelStreaming
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}