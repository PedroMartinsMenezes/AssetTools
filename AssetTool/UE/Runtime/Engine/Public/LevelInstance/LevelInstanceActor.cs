namespace AssetTool
{
    [JsonAsset("LevelInstance")]
    public class ALevelInstance : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}