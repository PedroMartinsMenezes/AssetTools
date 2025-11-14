namespace AssetTool
{
    [JsonAsset("LevelInstance")]
    public class ALevelInstance : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}