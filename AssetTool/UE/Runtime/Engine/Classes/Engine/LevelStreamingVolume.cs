namespace AssetTool
{
    [JsonAsset("LevelStreamingVolume")]
    public class ALevelStreamingVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}