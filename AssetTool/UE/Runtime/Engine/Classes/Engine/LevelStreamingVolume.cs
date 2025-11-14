namespace AssetTool
{
    [JsonAsset("LevelStreamingVolume")]
    public class ALevelStreamingVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}