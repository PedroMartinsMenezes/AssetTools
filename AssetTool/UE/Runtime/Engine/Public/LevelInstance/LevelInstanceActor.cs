namespace AssetTool
{
    [JsonAsset("LevelInstance")]
    public class ALevelInstance : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}