namespace AssetTool
{
    [JsonAsset("LevelStreamingPersistent")]
    public class ULevelStreamingPersistent : ULevelStreaming
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}