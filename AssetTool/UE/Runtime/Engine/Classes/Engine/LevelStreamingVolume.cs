namespace AssetTool
{
    [JsonAsset("LevelStreamingVolume")]
    public class ALevelStreamingVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}