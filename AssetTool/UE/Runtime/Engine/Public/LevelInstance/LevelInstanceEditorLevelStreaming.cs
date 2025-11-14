namespace AssetTool
{
    [JsonAsset("LevelStreamingLevelInstanceEditor")]
    public class ULevelStreamingLevelInstanceEditor : ULevelStreamingAlwaysLoaded
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}