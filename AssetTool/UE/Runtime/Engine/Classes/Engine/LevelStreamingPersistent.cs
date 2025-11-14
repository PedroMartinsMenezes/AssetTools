namespace AssetTool
{
    [JsonAsset("LevelStreamingPersistent")]
    public class ULevelStreamingPersistent : ULevelStreaming
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}